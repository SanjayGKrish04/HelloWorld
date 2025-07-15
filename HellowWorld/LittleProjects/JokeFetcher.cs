using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HellowWorld.LittleProjects
{
    public class JokeFetcher
    {
        public async Task FetchAndPrintJoke()
        {
            try
            {
                using HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");

                var joke = JsonSerializer.Deserialize<Joke>(response);

                if (joke != null)
                {
                    Console.WriteLine(joke.setup);
                    Console.WriteLine(joke.punchline);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to fetch joke: {ex.Message}");
            }
        }
    }

    public class Joke
    {
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }
}
