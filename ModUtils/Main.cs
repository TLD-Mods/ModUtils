using ModUtils.Classes;

namespace ModUtils
{
    internal sealed class Main : MelonMod
	{

		public override void OnInitializeMelon()
		{
			Console.Init();

			


		}

		internal static void Log(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.Magenta, line);
		}

		internal static void LogWarning(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.DarkYellow, "!!: "+line);
		}

		internal static void LogError(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.Red, "??: "+line);
		}


	}
}