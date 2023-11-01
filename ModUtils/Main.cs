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
			MelonLogger.Msg(System.ConsoleColor.Magenta,line);
		}


	}
}