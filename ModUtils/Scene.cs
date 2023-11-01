namespace ModUtils
{
	/// <summary>
	/// Scene Utilities
	/// </summary>
	public static class Scene
	{

		/// <summary>
		/// Get active scene name
		/// </summary>
		/// <returns></returns>
		public static string Name()
		{
			return GameManager.m_ActiveScene;
		}

		/// <summary>
		/// Get the instance name of the scene<para />
		/// (useful for instanced scenes like cabins or trailers)
		/// </summary>
		/// <returns></returns>
		public static string InstanceName()
		{
			return GameManager.m_SceneTransitionData.m_SceneSaveFilenameCurrent;
		}

		/// <summary>
		/// Check if the scene is a game scene<para />
		/// (not Empty,Boot,Menu)
		/// </summary>
		/// <param name="sceneName">If left null Scene.Name() will be used</param>
		/// <returns></returns>
		public static bool IsGameScene(string? sceneName = null)
		{
			sceneName = (string.IsNullOrEmpty(sceneName)) ? Name().ToLowerInvariant() : sceneName.ToLowerInvariant();
			if (
				GameManager.BOOT.ToLowerInvariant() == sceneName
				|| GameManager.EMPTY.ToLowerInvariant() == sceneName
				|| GameManager.GetTargetMainMenuSceneName().ToLowerInvariant() == sceneName
				|| string.IsNullOrEmpty(sceneName)
				)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Check if the scene is the primary scene of the SceneSet<para />
		/// (not _SANDBOX,_DLC01)
		/// </summary>
		/// <param name="sceneName">If left null Scene.Name() will be used</param>
		/// <returns></returns>
		public static bool IsPrimaryScene(string? sceneName = null)
		{
			sceneName = (string.IsNullOrEmpty(sceneName)) ? Name() : sceneName;
			SceneSet set = GameManager.m_ActiveSceneSet;
			return (set != null && set.m_BaseScene.AssetGUID == sceneName) ? true : false;
		}



	}
}
