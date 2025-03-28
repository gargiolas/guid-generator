namespace GuidGeneratorCli.GuidGenerator;

/// <summary>
/// A generator for creating ULIDs (Universally Unique Lexicographically Sortable Identifiers).
/// </summary>
/// <remarks>
/// The <see cref="UlidGenerator"/> class is a specialized implementation of the abstract <see cref="BaseGenerator"/> class.
/// It generates ULIDs using the current UTC timestamp and the <see cref="Ulid.NewUlid(DateTimeOffset)"/> method.
/// </remarks>
internal sealed class UlidGenerator : BaseGenerator
{
    /// <summary>
    /// Generates a new GUID (Globally Unique Identifier) string based on the specific implementation.
    /// </summary>
    /// <returns>A string representing a newly generated GUID.</returns>
    protected override string GenerateGuid() => Ulid.NewUlid(DateTimeOffset.UtcNow).ToString();
}