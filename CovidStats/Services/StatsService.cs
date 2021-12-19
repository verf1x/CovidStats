using System.Threading.Tasks;
using CovidStats.Interfaces;
using CovidStats.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace CovidStats.Services
{
    internal class StatsService : IStatsService
    {
        private static HttpClient _httpClient = new();

        public async Task<SummaryModel> GetData()
        {
            string request = "https://api.covid19api.com/summary";

            HttpResponseMessage response = (await _httpClient.GetAsync(request)).EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

#pragma warning disable CS8603 // Possible null reference return.
            return JsonConvert.DeserializeObject<SummaryModel>(responseBody);
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
