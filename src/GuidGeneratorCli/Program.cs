// See https://aka.ms/new-console-template for more information

using Cocona;
using GuidGeneratorCli.Constants;
using GuidGeneratorCli.GuidGenerator;

var builder = CoconaApp.CreateBuilder();

var app = builder.Build();

app.AddCommand("gtype", (
        [Option("guidType", Description = "The type of GUID (e.g., v4, v5, or default).")] string guidType,
        [Option(Description = "The number of GUIDs to generate. Default is 1.")] int occurrences = 1) =>
    {
        if (!ValidateGuidType(guidType)) return;

        var generatorType = GuidGeneratorFactory.Create(guidType.ToLower());

        if (occurrences > 1)
        {
            var guids = generatorType.GenerateMultipleGuids(occurrences);
            foreach (var singleGuid in guids)
                Console.WriteLine(singleGuid);
            return;
        }

        var guid = generatorType.Generate();
        Console.WriteLine(guid);
    })
    .WithDescription("Generates GUIDs of a specified type.");
app.Run();
return;

static bool ValidateGuidType(string guidType)
{
    if (Enum.TryParse(typeof(GuidTypes), guidType, true, out _)) return true;
    Console.WriteLine(
        $"Error: Invalid guidType '{guidType}'. Allowed values are: {string.Join(", ", Enum.GetNames(typeof(GuidTypes)))}");
    return false;
}