using Il2CppMS.Internal.Xml.XPath;
using ModUtils.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUtils
{
	/// <summary>
	/// GitHub Utilities
	/// </summary>
	public static class Github
	{


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
		public static bool SyncFile(string name, string remotePath, string localPath, UpdatePolicy updatePolicy = UpdatePolicy.Changed)
		{
			var g = new GitHubFile(name, remotePath, localPath, updatePolicy);
			return g.Updated;
		}


	}
}
