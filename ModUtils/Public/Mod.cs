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
            modName = modName.ToLowerInvariant();
            if (partialSearch)
            {
                MelonAssembly? assembly = MelonAssembly.LoadedAssemblies.FirstOrDefault(obj => obj.Assembly.GetName().Name.ToLowerInvariant().Contains(modName));
                return assembly != null;
            }
            else
            {
                MelonAssembly? assembly = MelonAssembly.LoadedAssemblies.FirstOrDefault(obj => obj.Assembly.GetName().Name.ToLowerInvariant() == modName);
                return assembly != null;
            }
        }



    }
}
