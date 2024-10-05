using System;
using System.Collections.Generic;

class ClimateData
{
    public double Rainfall { get; set; }
    public double RiverLevel { get; set; }
    public int Day { get; set; }

    // Simulate random data collection for 'days' number of days
    public static List<ClimateData> CollectClimateData(int days)
    {
        var data = new List<ClimateData>();
        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            data.Add(new ClimateData
            {
                Day = i,
                Rainfall = random.NextDouble() * 200,   // Random rainfall between 0 to 200 mm
                RiverLevel = random.NextDouble() * 20   // Random river level between 0 to 20 meters
            });
        }
        return data;
    }

    // Simulate real-time data retrieval
    public static ClimateData GetRealTimeData()
    {
        Random random = new Random();
        return new ClimateData
        {
            Rainfall = random.NextDouble() * 200,
            RiverLevel = random.NextDouble() * 20
        };
    }
}
