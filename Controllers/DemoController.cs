using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appinsight.Models;
using System.Net.Http;

namespace appinsight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class appinsightController : ControllerBase
    {
        private readonly string url = "https://tirs-web-secutils-backend.azurewebsites.net/api/HttpTrigger1?code=39_4B8SyGLbuZblWAEcKjYwvOwfGobKqZX3dMNKvvfkKAzFuddWyXg==";

        public appinsightController()
        {}

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
        }

    }
}