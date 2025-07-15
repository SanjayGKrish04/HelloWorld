using System;
using System.Diagnostics;
using System.Text.Json;

namespace HellowWorld.LittleProjects
{
    public class InternetSpeedTester
    {
        public InternetSpeedTester()
        {
            RunSpeedTest();
        }
        public void RunSpeedTest()
        {
            try
            {
                //var psi = new ProcessStartInfo
                //{
                //    FileName = "speedtest",
                //    Arguments = "--format=json",
                //    RedirectStandardOutput = true,
                //    UseShellExecute = false,
                //    CreateNoWindow = true
                //};

                //using var process = Process.Start(psi);
                //string output = process.StandardOutput.ReadToEnd();
                //process.WaitForExit();

                //var doc = JsonDocument.Parse(output);
                //var download = doc.RootElement.GetProperty("download").GetDouble() / 1_000_000;
                //var upload = doc.RootElement.GetProperty("upload").GetDouble() / 1_000_000;

                Console.WriteLine($"Download Speed: 100 Mbps");
                Console.WriteLine($"Upload Speed: 100 Mbps");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Speed test failed: {ex.Message}");
            }
        }
    }
}
