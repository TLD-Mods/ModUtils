[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCopyright(BuildInfo.ModAuthor)]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(ModUtils.Main), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]

[assembly: MelonGame("Hinterland", "TheLongDark")]

internal static class BuildInfo
{
	internal const string ModName = "ModUtils";
	internal const string ModAuthor = "STBlade";
	internal const string ModVersion = "1.0.0";
}