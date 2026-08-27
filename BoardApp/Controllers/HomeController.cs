using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ViewResult AddBoard()
    {
        //
        //Name             : ViewResult AddBoard()
        //Purpose          : Displays the form used to capture a new board
        //Re-use           : None
        //Input Parameters : None
        //Output Type      : ViewResult
        //                   - the view associated with this action
        //
        return View();
    } // end method

    [HttpPost]
    public IActionResult AddBoard(Board newBoard)
    {
        //
        //Name             : ViewResult AddBoard(Board newBoard)
        //Purpose          : Receives data from the AddBoard form,
        //                   adds the new board to the repository,
        //                   and redirects to the Home page.
        //Re-use           : None
        //Input Parameters : Board newBoard
        //                   - the board object created by the model binder
        //                   from the submitted form data.
        //Output Type      : ViewResult (redirecting to Index)
        //
        Repository.AddBoard(newBoard);
        return RedirectToAction("Index");
    } // end method

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
