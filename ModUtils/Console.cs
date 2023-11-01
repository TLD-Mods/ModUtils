namespace ModUtils
{
	internal static class Console
	{

		internal static void Init()
		{
			uConsole.RegisterCommand("mod_timeofday_lock", new Action(TimeOfDay.Lock));
			uConsole.RegisterCommand("mod_timeofday_unlock", new Action(TimeOfDay.Unlock));


			uConsole.RegisterCommand("modutils_test", new Action(Test));

		}

		internal static void Test()
		{
			// Scene Tests
			Main.Log($"Scene.Name {Scene.Name()}");
			Main.Log($"Scene.Name {Scene.InstanceName()}");
			Main.Log($"Scene.IsGameScene {Scene.IsGameScene()}");
			Main.Log($"Scene.IsPrimaryScene {Scene.IsPrimaryScene()}");

			// Mod Tests
			Main.Log($"Mod.IsLoaded modutils {Mod.IsLoaded("modutils")}");
			Main.Log($"Mod.IsLoaded utils true {Mod.IsLoaded("utils",true)}");

			// TimeOfDay Tests
			Main.Log($"TimeOfDay.IsLocked {TimeOfDay.IsLocked()}");
			Main.Log($"TimeOfDay.Lock {TimeOfDay.Lock} {TimeOfDay.IsLocked()}");
			Main.Log($"TimeOfDay.Unlock {TimeOfDay.Unlock} {TimeOfDay.IsLocked()}");

			// Player Tests
			Main.Log($"Player.Object {Player.Object()}");
			Main.Log($"Player.Position {Player.Position()}");

		}






	}
}
