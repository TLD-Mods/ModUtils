namespace ModUtils
{
	/// <summary>
	/// Mod/Assembly Utilities
	/// </summary>
	public static class Mod
	{
		/// <summary>
		/// Check if a mod is loaded
		/// </summary>
		/// <param name="modName">The Mod/Assembly name</param>
		/// <param name="partialSearch">(optional [bool])</param>
		/// <returns></returns>
		public static bool IsLoaded(string modName, bool partialSearch = false)
		{
			if (partialSearch)
			{
				MelonAssembly? assembly = MelonAssembly.LoadedAssemblies.FirstOrDefault(obj => obj.Assembly.GetName().Name.Contains(modName));
				return (assembly != null);
			}
			else
			{
				MelonAssembly? assembly = MelonAssembly.LoadedAssemblies.FirstOrDefault(obj => obj.Assembly.GetName().Name == modName);
				return (assembly != null);
			}
		}



	}
}
