namespace ModUtils.Extensions
{
	internal static class AssemblyExtensions
	{


		internal static string GetTrueResourceName(Assembly asm, string resourceName)
		{
			return asm.GetManifestResourceNames().FirstOrDefault(r => r.ToLowerInvariant().Contains(resourceName.ToLowerInvariant()));
		}

		/// <summary>
		/// Returns the embedded resource content as a string
		/// </summary>
		/// <param name="asm"></param>
		/// <param name="resourceName"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		internal static string? GetResource(this Assembly asm, string resourceName)
		{

			string trueResourceName = GetTrueResourceName(asm, resourceName);

			try
			{
				using Stream stream = asm.GetManifestResourceStream(trueResourceName) ?? throw new InvalidOperationException($"Failed to load resource: {trueResourceName}");
				using StreamReader reader = new(stream);
				string contents = reader.ReadToEnd();

				return contents;
			}
			catch (Exception ex)
			{
				Main.Log(ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Returns an embedded AssetBundle with the matching name
		/// </summary>
		/// <param name="asm"></param>
		/// <param name="bundleName"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		/// <exception cref="System.Exception"></exception>
		internal static AssetBundle? GetAssetBundle(this Assembly asm, string bundleName)
		{
			string trueResourceName = GetTrueResourceName(asm, bundleName);
			try
			{
				using Stream stream = asm.GetManifestResourceStream(trueResourceName) ?? throw new InvalidOperationException($"Failed to load resource: {trueResourceName}");
				MemoryStream memoryStream = new MemoryStream((int)stream.Length);
				stream.CopyTo(memoryStream);
				return memoryStream.Length != 0
				? AssetBundle.LoadFromMemory(memoryStream.ToArray())
				: throw new System.Exception($"No data in resource: {trueResourceName}");
			}
			catch (Exception ex)
			{
				Main.Log(ex.Message);
				return null;
			}
		}


	}
}
