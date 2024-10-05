class FloodPrediction
{
    const double RAIN_THRESHOLD = 150;  // mm
    const double RIVER_LEVEL_THRESHOLD = 10;  // meters

    public static bool IsFloodLikely(ClimateData data)
    {
        return data.Rainfall > RAIN_THRESHOLD && data.RiverLevel > RIVER_LEVEL_THRESHOLD;
    }

    public static List<string> PropagateFlood(string barangay, BarangayGraph barangayGraph)
    {
        var visited = new HashSet<string>();
        var queue = new Queue<string>();
        var floodAffected = new List<string>();

        queue.Enqueue(barangay);

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();
            if (!visited.Contains(current))
            {
                visited.Add(current);
                floodAffected.Add(current);

                List<string> neighbors = barangayGraph.GetConnections(current);
                if (neighbors != null)
                {
                    foreach (var neighbor in neighbors)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        return floodAffected;
    }
}
