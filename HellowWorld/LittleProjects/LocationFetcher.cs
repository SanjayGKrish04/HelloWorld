using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HellowWorld.LittleProjects
{
    public class LocationFetcher
    {
        public async Task GetCurrentLocation()
        {
            try
            {
                using HttpClient client = new HttpClient();
                string response = await client.GetStringAsync("http://ip-api.com/json");

                var location = JsonSerializer.Deserialize<Location>(response);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.lat}");
                    Console.WriteLine($"Longitude: {location.lon}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get location: {ex.Message}");
            }
        }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
}
