using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserGroups.Models;

namespace UserGroups.Controllers
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
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Groups = new List<GroupViewModel>()
            {
                new GroupViewModel("CatWorshippers", "For happy mommas and pappas of felines", 1035, "https://i.natgeofe.com/n/9135ca87-0115-4a22-8caf-d1bdef97a814/75552.jpg?w=636&h=424"),
                new GroupViewModel("DoggoHeaven", "Everything for your canine friends", 2531, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/dog-puppy-on-garden-royalty-free-image-1586966191.jpg?crop=1.00xw:0.669xh;0,0.190xh&resize=1200:*"),
                new GroupViewModel("RubberDuck", "Debugging best practices and more", 1305, "https://cdn11.bigcommerce.com/s-jnapaiw/images/stencil/1280x1280/products/2945/4049/Sunny_duck__52036.1400093435.jpg?c=2"),
                new GroupViewModel("LifeUniverseAndEverything", "Douglas Adams fan club", 972, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Bundesstra%C3%9Fe_42_number.svg/1200px-Bundesstra%C3%9Fe_42_number.svg.png")
            };
            return View(viewModel);
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
