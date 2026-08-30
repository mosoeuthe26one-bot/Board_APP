// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Assessment 1
// Purpose         : Handles the home page, privacy page, and error page
//                   for the application.

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //
            //Name             : HomeController(ILogger<HomeController> logger)
            //Purpose          : Constructor that stores the injected logger
            //                   for use elsewhere in the controller
            //Re-use           : None
            //Input Parameters : ILogger<HomeController> logger
            //                   - the logger service provided by
            //                     dependency injection
            //Output Type      : None
            //
            _logger = logger;
        } // end method

        public IActionResult Index()
        {
            //
            //Name             : IActionResult Index()
            //Purpose          : Displays the home page
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : IActionResult
            //                   - the default Index view
            //
            return View();
        } // end method

        public IActionResult Privacy()
        {
            //
            //Name             : IActionResult Privacy()
            //Purpose          : Displays the privacy policy page
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : IActionResult
            //                   - the default Privacy view
            //
            return View();
        } // end method

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //
            //Name             : IActionResult Error()
            //Purpose          : Displays the error page, showing the
            //                   current request's trace identifier
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : IActionResult
            //                   - the default Error view, with an
            //                     ErrorViewModel
            //
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } // end method
    } // end class
} // end namespace