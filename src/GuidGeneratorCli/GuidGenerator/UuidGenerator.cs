namespace GuidGeneratorCli.GuidGenerator;

/// <summary>
/// A generator for creating UUIDs (Universally Unique Identifiers) using the .NET's <see cref="System.Guid"/> type.
/// </summary>
/// <remarks>
/// The <see cref="UuidGenerator"/> class is a specialized implementation of the abstract <see cref="BaseGenerator"/> class.
/// It uses the <see cref="Guid.NewGuid()"/> method to generate unique identifiers.
/// </remarks>
internal sealed class UuidGenerator : BaseGenerator
{
    /// <summary>
    /// Generates a new GUID (Globally Unique Identifier) string.
    /// </summary>
    /// <returns>A string representing a newly generated GUID.</returns>
    protected override string GenerateGuid()=> Guid.NewGuid().ToString();
}