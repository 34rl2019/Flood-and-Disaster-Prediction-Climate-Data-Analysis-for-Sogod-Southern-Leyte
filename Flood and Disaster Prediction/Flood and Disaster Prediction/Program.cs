using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // 1. Set up the barangay graph
        BarangayGraph barangays = new BarangayGraph();
        barangays.AddBarangay("Zone V");
        barangays.AddBarangay("Zone IV");
        barangays.AddBarangay("Zone III");
        barangays.AddConnection("Zone V", "Zone IV");
        barangays.AddConnection("Zone IV", "Zone III");

        // 2. Start real-time monitoring for flood prediction
        RealTimeMonitor.Monitor(barangays);
    }
}
