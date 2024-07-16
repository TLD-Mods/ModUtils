namespace ModUtils
{

	/// <summary>
	/// Console Commands<para />
	/// mu_test<para />
	/// mu_timeofday_lock<br />
	/// mu_timeofday_unlock<br />
	/// </summary>
	internal static class Console
	{

		internal static void Init()
		{
			uConsole.RegisterCommand("mu_test", new Action(Test));
		}

		internal static void Test()
		{
			Stopwatch sw = Stopwatch.StartNew();
			// Scene Tests
			Main.Log($"Scene.Name | {Scene.Name()}");
			Main.Log($"Scene.DisplayName | {Scene.DisplayName()}");
			Main.Log($"Scene.RegionName | {Scene.RegionName()}");
			Main.Log($"Scene.RegionDisplayName | {Scene.RegionDisplayName()}");
			Main.Log($"Scene.InstanceName | {Scene.InstanceName()}");
			Main.Log($"Scene.IsGameScene | {Scene.IsGameScene()}");
			Main.Log($"Scene.IsInstance | {Scene.IsInstance()}");
			Main.Log($"Scene.IsFirstLoad | {Scene.IsFirstLoad()}");
			Main.Log($"Scene.IsPrimaryScene | {Scene.IsPrimaryScene()}");
			Main.Log($"Scene.GetActiveSceneSet | {Scene.GetActiveSceneSet()}");
			Main.Log($"Scene.GetActiveSceneSetBaseScene | {Scene.GetActiveSceneSetBaseScene()}");

			Main.Log($"UI.OverlayActive | {UI.OverlayActive().ToString()}");


			// Mod Tests
			Main.Log($"Mod.IsLoaded modutils | {Mod.IsLoaded("modutils")}");
			Main.Log($"Mod.IsLoaded modu false | {Mod.IsLoaded("modu", false)}");
			Main.Log($"Mod.IsLoaded modu true | {Mod.IsLoaded("modu", true)}");

			// Player Tests
			Main.Log($"Player.Object | {Player.Object()}");
			Main.Log($"Player.Position | {Player.Position()}");
			Main.Log($"Player.Camera | {Player.Camera()}");

			// Extensions tests
			Main.Log($"Ext.GameObject.HasComponent | {Player.Object().HasComponent<vp_FPSPlayer>()}");
			Main.Log($"Ext.Assembly.GetResourceAsString | {Assembly.GetExecutingAssembly().GetResource("TestEmbed.txt")}");
			Main.Log($"Ext.Assembly.GetAssetBundle | {Assembly.GetExecutingAssembly().GetAssetBundle("TestBundle").name}");

			sw.Stop();
			Main.Log($"Test Complete: {sw.ElapsedMilliseconds}ms");

		}






	}
}
