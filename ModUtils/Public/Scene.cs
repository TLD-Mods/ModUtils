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
			return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
		}

		/// <summary>
		/// Get scene display name
		/// </summary>
		/// <param name="sceneName">If left null Scene.Name() will be used</param>
		/// <returns></returns>
		public static string DisplayName(string? sceneName = null)
		{
			sceneName = string.IsNullOrEmpty(sceneName) ? Name() : sceneName;
			return InterfaceManager.GetNameForScene(sceneName);
		}

		/// <summary>
		/// Get scene region name
		/// </summary>
		/// <param name="sceneName">If left null Scene.Name() will be used</param>
		/// <returns></returns>
		public static string RegionName(string? sceneName = null)
		{
			sceneName = string.IsNullOrEmpty(sceneName) ? Name() : sceneName;
			return InterfaceManager.GetRegionForScene(sceneName);
		}

		/// <summary>
		/// Get scene region display name
		/// </summary>
		/// <param name="sceneName">If left null Scene.Name() will be used</param>
		/// <returns></returns>
		public static string RegionDisplayName(string? sceneName = null)
		{
			sceneName = string.IsNullOrEmpty(sceneName) ? Name() : sceneName;
			return DisplayName(RegionName(sceneName));
		}

		/// <summary>
		/// Get the instance name of the active scene<para />
		/// (useful for instanced scenes like cabins or trailers)
		/// </summary>
		/// <returns></returns>
		public static string InstanceName()
        {
            return GameManager.m_SceneTransitionData.m_SceneSaveFilenameCurrent;
        }


        /// <summary>
        /// Chekc if the current active scene is an instance<para />
        /// (Cabin or Trailer)
        /// </summary>
        /// <returns></returns>
        public static bool IsInstance()
        {
            return InstanceName() != Name() && InstanceName().Length > Name().Length ? true : false;
        }


        /// <summary>
        /// Check if the scene is a game scene<para />
        /// (not Empty,Boot,Menu)
        /// </summary>
        /// <param name="sceneName">If left null Scene.Name() will be used</param>
        /// <returns></returns>
        public static bool IsGameScene(string? sceneName = null)
        {
            sceneName = string.IsNullOrEmpty(sceneName) ? Name().ToLowerInvariant() : sceneName.ToLowerInvariant();
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
        /// NOT WORKING!! Check if the scene is the primary scene of the SceneSet<para />
        /// (not _SANDBOX,_DLC01)
        /// </summary>
        /// <param name="sceneName">If left null Scene.Name() will be used</param>
        /// <returns></returns>
        public static bool IsPrimaryScene(string? sceneName = null)
        {
            sceneName = string.IsNullOrEmpty(sceneName) ? Name() : sceneName;
            SceneSet set = GameManager.m_ActiveSceneSet;
            return set != null && GetActiveSceneSetBaseScene() == sceneName ? true : false;
        }

        /// <summary>
        /// Gets the current active SceneSet
        /// </summary>
        /// <returns></returns>
        public static SceneSet GetActiveSceneSet()
        {
            return GameManager.m_ActiveSceneSet;
        }

        /// <summary>
        /// NOT WORKING!! Gets the base scene name from the current active SceneSet
        /// </summary>
        /// <returns></returns>
        public static string? GetActiveSceneSetBaseScene()
        {
            if (GetActiveSceneSet() == null)
            {
                return null;
            }
            return GetActiveSceneSet().m_BaseScene.AssetGUID;
        }

        /// <summary>
        /// Check if this is the first time the scene was loaded
        /// </summary>
        /// <returns></returns>
        public static bool IsFirstLoad()
        {
            return IsGameScene() && !GameManager.m_SceneWasRestored;
        }

		/// <summary>
		/// Is the current scene Indoors
		/// </summary>
		/// <returns></returns>
		public static bool IsIndoors()
		{
			return GameManager.GetWeatherComponent().IsIndoorScene();
		}

		/// <summary>
		/// Is the current scene Outdoors
		/// </summary>
		/// <returns></returns>
		public static bool IsOutdoors()
		{
			return !IsIndoors();
		}



	}
}
