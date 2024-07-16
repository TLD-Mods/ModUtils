using MelonLoader.Utils;
using System.Net;

namespace ModUtils.Classes
{
	/// <summary>
	/// GitHubFile Definition
	/// </summary>
	internal class GitHubFile
	{
		/// <summary>
		/// Used solely for debugging output
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Full RAW github path
		/// </summary>
		public string RemotePath { get; set; }
		/// <summary>
		/// Local path, relative to \Mods\ folder
		/// </summary>
		public string LocalPath { get; set; }
		/// <summary>
		/// When to update the local from remote
		/// Default : Changed
		/// </summary>
		public UpdatePolicy UpdatePolicy { get; set; } = UpdatePolicy.Changed;
		/// <summary>
		/// Returns true if the file updated
		/// </summary>
		public bool Updated { get; set; } = false;
		/// <summary>
		/// Returns true if the supplied information is valid
		/// </summary>
		public bool Valid { get; set; } = false;

		private string AbsoluteLocalPath => Path.Combine(MelonEnvironment.ModsDirectory, LocalPath);
		private string FileName => Path.GetFileName(LocalPath);


		/// <summary>
		/// <b>(string) name</b><br /><i>Used solely for debugging output</i><br /><br />
		/// <b>(string) remotePath</b><br /><i>Full RAW github path</i><br /><br />
		/// <b>(string) localPath</b><br /><i>Local path, relative to \Mods\ folder</i><br /><br />
		/// <b>(UpdatePolicy) updatePolicy</b><br /><i>When to update the local file from remote (Default: Changed)</i>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="remotePath"></param>
		/// <param name="localPath"></param>
		/// <param name="updatePolicy"></param>
		internal GitHubFile(string name, string remotePath, string localPath, UpdatePolicy updatePolicy = UpdatePolicy.Changed)
		{
			this.Name = name;
			this.RemotePath = remotePath;
			this.LocalPath = localPath;
			this.UpdatePolicy = updatePolicy;
			this.Valid = this.Validate();
			this.Updated = this.Update();
		}


		private void LogInvalid(string msg)
		{
			Main.LogWarning($"GitHub.SyncFile ({this.Name}) !!{msg}");
		}

		private bool Validate()
		{
			if (
				string.IsNullOrEmpty(this.RemotePath)
				|| !this.RemotePath.ToLowerInvariant().StartsWith("https://raw.githubusercontent.com")
				)
			{
				LogInvalid("Invalid RemotePath");
				return false;
			}

			if (
				string.IsNullOrEmpty(this.LocalPath)
				|| this.LocalPath.Contains(@"..")
				|| Path.GetInvalidFileNameChars().Any(this.FileName.Contains)
				|| Path.GetInvalidPathChars().Any(this.LocalPath.Contains)
				)
			{
				LogInvalid($"Invalid LocalPath ({this.LocalPath}) ({this.AbsoluteLocalPath})");
				return false;
			}


			if (Directory.Exists(this.AbsoluteLocalPath))
			{
				LogInvalid($"LocalPath is directory");
				return false;
			}

			return true;
		}
		private bool Update()
		{
			if (!this.Valid)
			{
				return false;
			}

			bool needsUpdate = this.CheckForUpdate();
			if (needsUpdate)
			{
				try
				{
					using (WebClient client = new WebClient())
					{
						string content = client.DownloadString(this.RemotePath);
						if (!string.IsNullOrEmpty(content))
						{
							string directory = Path.GetDirectoryName(this.AbsoluteLocalPath);
							if (!Directory.Exists(directory))
							{
								Directory.CreateDirectory(directory);
							}

							File.WriteAllText(this.AbsoluteLocalPath, content);
						}
						content = null;
					}
					return true;
				}
				catch (Exception e)
				{
					Main.LogError($"Unable to get : {this.FileName} ({this.LocalPath}) {e.ToString()}");
					return false;
				}
			}
			return false;
		}

		private bool CheckForUpdate()
		{
			if (this.UpdatePolicy == UpdatePolicy.Always)
			{
				return true;
			}

			if (this.UpdatePolicy == UpdatePolicy.Changed)
			{
				if (!File.Exists(this.AbsoluteLocalPath))
				{
					return true;
				}

				try
				{
					using (WebClient client = new WebClient())
					{
						using (var openRead = client.OpenRead(this.RemotePath))
						{
							long remoteSize = long.Parse(client.ResponseHeaders["Content-Length"]);
							long localSize = new FileInfo(this.AbsoluteLocalPath).Length;

							if (localSize != remoteSize)
							{
								return true;
							}
						}
					}
				}
				catch (Exception e)
				{
					Main.LogWarning($"Unable to get Headers : {this.FileName} ({this.LocalPath}) {e.ToString()}");
					return false;
				}
			}

			if (this.UpdatePolicy == UpdatePolicy.Initial)
			{
				if (!File.Exists(this.AbsoluteLocalPath))
				{
					return true;
				}
			}


			return false;
		}


	}

	public enum UpdatePolicy
	{
		Changed = 0,
		Initial = 95,
		Always = 99,
	}
}
