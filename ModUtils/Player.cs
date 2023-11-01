namespace ModUtils
{
	/// <summary>
	/// Player Utilities
	/// </summary>
	public static class Player
	{

		/// <summary>
		/// Get the Player Object
		/// </summary>
		/// <returns></returns>
		public static GameObject? Object()
		{
			return (GameManager.GetPlayerObject() != null) ? GameManager.GetPlayerObject() : null;
		}

		/// <summary>
		/// Get the Player Position
		/// </summary>
		/// <returns></returns>
		public static Vector3? Position()
		{
			return (GameManager.GetPlayerTransform() != null) ? GameManager.GetPlayerTransform().position : null;
		}
	}
}
