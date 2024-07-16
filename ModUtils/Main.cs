namespace ModUtils
{
	internal sealed class Main : MelonMod
	{

		public override void OnInitializeMelon()
		{
			Console.Init();
		}


		public override void OnUpdate()
		{
			if (Input.GetKeyDown(KeyCode.T))
			{
				Console.Test();
			}
		}


		internal static void Log(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.Magenta, line);
		}

		internal static void LogWarning(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.DarkYellow, "!!: " + line);
		}

		internal static void LogError(string line)
		{
			MelonLogger.Msg(System.ConsoleColor.Red, "??: " + line);
		}


	}
}