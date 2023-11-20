using System.Text.Json.Serialization;

namespace ClientOfUselessInfo
{
    internal class Program
    {
        private const string UriString = "https://uselessfacts.jsph.pl/api/v2/facts/random";

        static async Task Main(string[] args)
        {
            var response = await ClientService.GetData(UriString);
            string json = await response.Content.ReadAsStringAsync();
                              
        }
    }
}
