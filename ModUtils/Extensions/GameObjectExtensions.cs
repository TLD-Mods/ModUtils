namespace ModUtils.Extensions
{
    internal static class GameObjectExtensions
    {
        /// <summary>
        /// Checks if the GameObject has a component of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="go"></param>
        /// <param name="checkChildren">(optional [bool])</param>
        /// <param name="checkParent">(optional [bool])</param>
        /// <returns>bool true|false</returns>
        internal static bool HasComponent<T>(this UnityEngine.GameObject go, bool checkChildren = false, bool checkParent = false) where T : Component
        {
            if (checkChildren && checkParent)
            {
                return go.transform.parent.gameObject.GetComponentsInChildren<T>() != null;
            }

            if (checkChildren)
            {
                return go.GetComponentInChildren<T>() != null;
            }
            if (checkParent)
            {
                return go.transform.parent.gameObject.GetComponent<T>() != null;
            }
            if (!checkChildren && !checkParent)
            {
                return go.GetComponent<T>() != null;
            }
            return false;
        }

		/// <summary>
		/// Shorthand for HasComponent GearItem
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsGearItem(this UnityEngine.GameObject go) => go.HasComponent<Item>();


		/// <summary>
		/// Shorthand for HasComponent&lt;FoodItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsFoodItem(this UnityEngine.GameObject go) => go.HasComponent<FoodItem>();


		/// <summary>
		/// Shorthand for HasComponent&lt;ToolsItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsToolsItem(this UnityEngine.GameObject go) => go.HasComponent<ToolsItem>();


		/// <summary>
		/// Shorthand for HasComponent&lt;StoneItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsStoneItem(this UnityEngine.GameObject go) => go.HasComponent<StoneItem>();


		/// <summary>
		/// Shorthand for HasComponent&lt;FuelSourceItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsFuelSource(this UnityEngine.GameObject go) => go.HasComponent<FuelSourceItem>();


		/// <summary>
		/// Shorthand for HasComponent&lt;Cookable&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsCookable(this UnityEngine.GameObject go) => go.HasComponent<Cookable>();

		/// <summary>
		/// Shorthand for HasComponent&lt;Harvestable&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsHarvestable(this UnityEngine.GameObject go) => go.HasComponent<Harvestable>();

		/// <summary>
		/// Shorthand for HasComponent&lt;BodyHarvest&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsBodyHarvest(this UnityEngine.GameObject go) => go.HasComponent<BodyHarvest>();

		/// <summary>
		/// Shorthand for HasComponent&lt;Container&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsContainer(this UnityEngine.GameObject go) => go.HasComponent<Container>();

		/// <summary>
		/// Shorthand for HasComponent&lt;FlareItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsFlareItem(this UnityEngine.GameObject go) => go.HasComponent<FlareItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;TorchItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsTorchItem(this UnityEngine.GameObject go) => go.HasComponent<TorchItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;FirstAidItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsFirstAidItem(this UnityEngine.GameObject go) => go.HasComponent<FirstAidItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;LiquidItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsLiquidItem(this UnityEngine.GameObject go) => go.HasComponent<LiquidItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;RopeItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsRopeItem(this UnityEngine.GameObject go) => go.HasComponent<RopeItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;ResearchItem&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsResearchItem(this UnityEngine.GameObject go) => go.HasComponent<ResearchItem>();

		/// <summary>
		/// Shorthand for HasComponent&lt;Bed&gt;
		/// </summary>
		/// <param name="go"></param>
		/// <returns></returns>
		internal static bool IsBed(this UnityEngine.GameObject go) => go.HasComponent<Bed>();
		





	}
}
