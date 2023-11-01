
namespace ModUtils
{
	/// <summary>
	/// Time of Day Utilities
	/// </summary>
	public static class TimeOfDay
	{

		/// <summary>
		/// Lock the Time Of Day
		/// </summary>
		public static void Lock()
		{
			GameManager.GetTimeOfDayComponent().SetTODLocked(true);
		}
		/// <summary>
		/// UnLock the Time Of Day
		/// </summary>
		public static void Unlock()
		{
			GameManager.GetTimeOfDayComponent().SetTODLocked(false);
		}
		/// <summary>
		/// check if the Time Of Day is locked
		/// </summary>
		/// <returns></returns>
		public static bool IsLocked()
		{
			return GameManager.GetTimeOfDayComponent().IsTODLocked();
		}

	}
}
