using System.Collections.Generic;

class BarangayGraph
{
    private Dictionary<string, List<string>> graph;

    public BarangayGraph()
    {
        graph = new Dictionary<string, List<string>>();
    }

    public void AddBarangay(string barangay)
    {
        if (!graph.ContainsKey(barangay))
        {
            graph[barangay] = new List<string>();
        }
    }

    public void AddConnection(string barangay1, string barangay2)
    {
        if (!graph.ContainsKey(barangay1)) AddBarangay(barangay1);
        if (!graph.ContainsKey(barangay2)) AddBarangay(barangay2);

        graph[barangay1].Add(barangay2);
        graph[barangay2].Add(barangay1);
    }

    public List<string> GetConnections(string barangay)
    {
        return graph.ContainsKey(barangay) ? graph[barangay] : null;
    }

    public void DisplayGraph()
    {
        foreach (var barangay in graph)
        {
            Console.WriteLine($"{barangay.Key} -> {string.Join(", ", barangay.Value)}");
        }
    }
}
