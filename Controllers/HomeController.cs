using CameraDesription.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CameraDesription.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<CameraDetail> cameraDetails = new List<CameraDetail>();
            using (var client = new HttpClient())
            {
     
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("https://localhost:44321/api/Search/ConvertCSVtoDataTable").Result;
                if (response.IsSuccessStatusCode)
                {
                   var result = response.Content.ReadAsStringAsync().Result;
                    cameraDetails = JsonConvert.DeserializeObject<List<CameraDetail>>(result);

                }
                return View(cameraDetails);
            }
        }
        
    }
}
