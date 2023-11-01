namespace ModUtils
{
	internal static class Extensions
	{
		/// <summary>
		/// Checks if the GameObject has a component of type &lt;T&gt;
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="go"></param>
		/// <param name="checkChildren">(optional [bool])</param>
		/// <param name="checkParent">(optional [bool])</param>
		/// <returns>bool true|false</returns>
		internal static bool HasComponent<T>(this GameObject go, bool checkChildren = false, bool checkParent = false) where T : Component
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
	}
}
