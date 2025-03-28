using GuidGeneratorCli.GuidGenerator;

namespace GuidGeneratorCli;

/// <summary>
/// Abstract base class for generating unique identifiers such as GUIDs, UUIDs, or ULIDs.
/// </summary>
/// <remarks>
/// The <see cref="BaseGenerator"/> class provides a foundation for implementing identifier generators.
/// It defines common functionality for generating single or multiple identifiers while delegating
/// the actual generation logic to derived classes through the abstract <see cref="GenerateGuid"/> method.
/// </remarks>
internal abstract class BaseGenerator : IGuidGenerator
{
    /// <summary>
    /// Generates and returns a single GUID (Globally Unique Identifier) as a string,
    /// using the implementation defined in the derived class.
    /// </summary>
    /// <returns>A string representing the generated GUID.</returns>
    public string Generate() => GenerateGuid();

    /// <summary>
    /// Generates multiple GUIDs (Globally Unique Identifiers) as strings.
    /// </summary>
    /// <param name="quantity">The number of GUIDs to generate.</param>
    /// <returns>An array of strings containing the generated GUIDs.</returns>
    public string[] GenerateMultipleGuids(int quantity)
    {
        var guids = new string[quantity];
        
        for (var progressive = 0; progressive < quantity; progressive++)
        {
            guids[progressive] = GenerateGuid();
        }

        return guids;
    }

    /// <summary>
    /// Generates a GUID (Globally Unique Identifier) as a string.
    /// </summary>
    /// <returns>
    /// A string representation of the generated GUID.
    /// </returns>
    protected abstract string GenerateGuid();
}