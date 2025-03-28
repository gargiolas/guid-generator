namespace GuidGeneratorCli.GuidGenerator;

/// <summary>
/// Represents a mechanism for generating GUIDs (Globally Unique Identifiers).
/// </summary>
internal interface IGuidGenerator
{
    /// <summary>
    /// Generates and returns a single GUID (Globally Unique Identifier) as a string.
    /// </summary>
    /// <returns>A string representing a new GUID.</returns>
    string Generate();

    /// <summary>
    /// Generates multiple GUIDs (Globally Unique Identifiers) based on the specified quantity.
    /// </summary>
    /// <param name="quantity">The number of GUIDs to generate.</param>
    /// <returns>An array of generated GUIDs as strings.</returns>
    string[] GenerateMultipleGuids(int quantity);
}