using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IHttpClientFactory clientFactory
            )
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }


        
        [HttpGet]
        public async Task<string> Get()
        {
            string uri = "https://localhost:5001/WeatherForecast";

            var request = new HttpRequestMessage(HttpMethod.Get,
                uri);
            request.Headers.Add("X-API-KEY", "123");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
