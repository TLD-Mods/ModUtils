namespace ModUtils;

public static class Item
{
    /// <summary>
    /// Gets any component attached to the GameObject of a GearItem.
    /// </summary>
    /// <param name="gearItem">An instance of a GearItem</param>
    /// <typeparam name="T">The component you are getting</typeparam>
    public static T GetComponentOnGearItem<T>(GearItem gearItem) where T : Component => gearItem.GetComponent<T>();

    /// <summary>
    /// This method needs to be called under the GearItem.Awake() harmony patch.
    /// </summary>
    /// <param name="gearItem">A reference to a GearItem.</param>
    /// <param name="customGearItemName">The name of your custom GearItem.</param>
    /// <typeparam name="T">The new component your attaching.</typeparam>
    public static void AttachCustomComponentToGearItem<T>(GearItem gearItem, string customGearItemName) where T : Component
    {
        if (gearItem.name.Contains(customGearItemName)) _ = gearItem.GetComponent<T>() ?? gearItem.gameObject.AddComponent<T>();
    }
}