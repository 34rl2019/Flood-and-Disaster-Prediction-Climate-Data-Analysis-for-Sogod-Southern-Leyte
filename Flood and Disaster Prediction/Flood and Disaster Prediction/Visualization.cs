class Visualization
{
    public static void DisplayAffectedAreas(List<string> affectedAreas)
    {
        Dictionary<string, string> mapTemplate = new Dictionary<string, string>
        {
            { "Zone V", "[V]" },
            { "Zone IV", "[IV]" },
            { "Zone III", "[III]" }
        };

        foreach (var barangay in affectedAreas)
        {
            mapTemplate[barangay] = "[X]";  // Mark as flooded
        }

        Console.WriteLine($"Barangay Zone V: {mapTemplate["Zone V"]}");
        Console.WriteLine($"Barangay Zone IV: {mapTemplate["Zone IV"]}");
        Console.WriteLine($"Barangay Zone III: {mapTemplate["Zone III"]}");
    }
}
