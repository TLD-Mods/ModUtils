namespace ModUtils
{
	public static class UI
	{


		/// <summary>
		/// Check in any Overlay is active
		/// </summary>
		/// <returns></returns>
		public static bool OverlayActive()
		{
			return InterfaceManager.GetInstance().AnyOverlayPanelEnabled();
		}

	}
}
