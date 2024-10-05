using System.Threading;

class RealTimeMonitor
{
    public static void Monitor(BarangayGraph barangayGraph)
    {
        while (true)
        {
            ClimateData realTimeData = ClimateData.GetRealTimeData();
            Console.WriteLine($"Real-time data - Rainfall: {realTimeData.Rainfall:F2} mm, River Level: {realTimeData.RiverLevel:F2} m");

            if (FloodPrediction.IsFloodLikely(realTimeData))
            {
                List<string> affectedAreas = FloodPrediction.PropagateFlood("Zone V", barangayGraph);
                Console.WriteLine($"Flood Alert! Areas affected: {string.Join(", ", affectedAreas)}");
            }
            else
            {
                Console.WriteLine("No flood threat detected.");
            }

            Thread.Sleep(5000);  // Sleep for 5 seconds before the next check
        }
    }
}
