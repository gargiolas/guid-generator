namespace GuidGeneratorCli.GuidGenerator;

/// <summary>
/// A factory class for creating instances of implementations of the <see cref="IGuidGenerator"/> interface,
/// based on the specified GUID type.
/// </summary>
internal static class GuidGeneratorFactory
{
    internal static IGuidGenerator Create(string guidType)
    {
        return guidType switch
        {
            "ulid" => new UlidGenerator(),
            "guid" => new UuidGenerator(),
            "guidv7" => new UuidV7Generator(),
            _ => throw new ArgumentException($"Invalid guidType: {guidType}")
        };
    }
}