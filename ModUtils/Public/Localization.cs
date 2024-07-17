using LocalizationUtilities;

namespace ModUtils;

/// <summary>
/// Utility methods for anything regarding LocalizationUtilities
/// </summary>
public static class Localization
{
    /// <summary>
    /// Register custom localizations within The Long Dark.
    /// </summary>
    /// <param name="jsonFilePath">An embedded path to your localization .json file. E.g. ItemRarities.Resources.Localization.json</param>
    public static void RegisterLocalizationKeys(string jsonFilePath)
    {
        if (string.IsNullOrWhiteSpace(jsonFilePath)) throw new ArgumentNullException(nameof(jsonFilePath));

        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(jsonFilePath);
        if (stream == null) throw new FileNotFoundException($"Resource not found: {jsonFilePath}");

        using var reader = new StreamReader(stream);
        var jsonText = reader.ReadToEnd();

        if (string.IsNullOrWhiteSpace(jsonText)) throw new InvalidDataException("JSON content is empty or whitespace.");

        LocalizationManager.LoadJsonLocalization(jsonText);
    }
}