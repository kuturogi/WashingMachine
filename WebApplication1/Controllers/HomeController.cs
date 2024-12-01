using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;



namespace WebApplication1.Controllers
{
    namespace YourNamespace.Controllers
    {
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                var washingMachines = new List<WashingMachine>
            {
                new WashingMachine { Model = "CM-1", Status = "ÇALIŞMIYOR", Weight = "5 KG", Time = "00:00", Name = "Hasan Karadağ" },
                new WashingMachine { Model = "CM-2", Status = "ÇALIŞIYOR", Weight = "7 KG", Time = "01:30", Name = "Ahmet Yılmaz" }
            };

                return View(washingMachines);
            }
        }
    }
}
