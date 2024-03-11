using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using RainfallApi.Models;


namespace RainfallApi.Controllers
{
    [Route("api/[controller]/id")]
    [ApiController]
    public class RainfallController : ControllerBase
    {
        private readonly ILogger<RainfallController> _logger;

        public RainfallController(ILogger<RainfallController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRainfall/{stationId}")]
        public async Task<List<RainfallItem>> GetRainfall(int stationId)
        {
            HttpClient client = new HttpClient();

            RainfallReadingModel _result = new RainfallReadingModel();
            string url = string.Concat("https://environment.data.gov.uk/flood-monitoring/id/stations/", stationId, "/readings?_sorted&_limit=10");
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string _resultText = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(_resultText))
                {
                    _result = JsonConvert.DeserializeObject<RainfallReadingModel>(_resultText);
                }
            }
            return _result.items;
        }
    }
}
