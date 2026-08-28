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

    [HttpGet]
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
    public ViewResult AddBoard(Board board)
    {
        //
        //Name             : ViewResult AddBoard(Board board)
        //Purpose          : Receives data from the AddBoard form. If the
        //                   submitted data is valid, adds the new board to
        //                   the repository and shows a confirmation view.
        //                   Otherwise redisplays the form with the user's
        //                   errors shown.
        //Re-use           : None
        //Input Parameters : Board board
        //                   - the board object created by the model binder
        //                     from the submitted form data
        //Output Type      : ViewResult
        //                   - either the BoardAdded confirmation view, or
        //                     the AddBoard form redisplayed with errors
        //
        if (ModelState.IsValid)
        {
            Repository.AddBoard(board);
            return View("BoardAdded", board);
        }
        return View();
} // end method

    public ViewResult ListBoards()
    {
        //
        //Name             : ViewResult ListBoards()
        //Purpose          : Displays every board currently in the repository
        //Re-use           : None
        //Input Parameters : None
        //Output Type      : ViewResult
        //                   - the view listing all boards
        //
        return View(Repository.Boards);
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