namespace GuidGeneratorCli.GuidGenerator;

/// <summary>
/// A class responsible for generating UUID Version 7 (Sortable Time-based UUIDs).
/// </summary>
/// <remarks>
/// UUID Version 7 is designed to produce time-ordered UUIDs based on the current timestamp,
/// facilitating efficient database indexing and ordered record storage.
/// </remarks>
internal sealed class UuidV7Generator : BaseGenerator
{
    /// <summary>
    /// Generates a GUID (Globally Unique Identifier) as a string.
    /// </summary>
    /// <remarks>
    /// This method provides an implementation-specific approach to generating a GUID,
    /// which may differ depending on the concrete implementation of the derived class.
    /// </remarks>
    /// <returns>
    /// A string representation of the generated GUID.
    /// </returns>
    protected override string GenerateGuid() => Guid.CreateVersion7(DateTimeOffset.UtcNow).ToString();
}