using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index(int pageSize = 30)
        {
            CarCrashViewModel carCrashView = new CarCrashViewModel();

            try
            {
                using (var client = new HttpClient())
                {
                    carCrashView.PreviousPageIndex = pageSize > 30 ? pageSize -30: 0;
                    carCrashView.CurrentPageIndex = pageSize;
                    // client.BaseAddress = new Uri("https://data.cityofnewyork.us/resource/h9gi-nx95.json");
                    var apiResponse = await client.GetAsync("https://data.cityofnewyork.us/resource/h9gi-nx95.json");
                    var data = await apiResponse.Content.ReadAsStringAsync();
                    //var carCrashView1 = JsonConvert.DeserializeObject<Root>(data);
                    var desObj = JsonConvert.DeserializeObject<List<CarCrash>>(data);
                    if(carCrashView.CurrentPageIndex <desObj.Count )
                    {
                        carCrashView.CarCrashes = desObj.GetRange(carCrashView.PreviousPageIndex, carCrashView.CurrentPageIndex);
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
           
            return View(carCrashView);
        }

       


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
