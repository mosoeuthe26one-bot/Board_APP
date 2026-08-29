// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Worksheet 3
// Purpose         : Handles listing and viewing details of boards,
//                   separating board-related concerns from
//                   HomeController.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            //
            //Name             : IActionResult Index()
            //Purpose          : Displays every board currently in the
            //                   repository
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : IActionResult
            //                   - the view listing all boards
            //
            return View(Repository.Boards);
        } // end method

        public IActionResult Details(string boardCode)
        {
            //
            //Name             : IActionResult Details(string boardCode)
            //Purpose          : Displays the details of a single board
            //                   matching the given board code
            //Re-use           : None
            //Input Parameters : string boardCode
            //                   - the board code to look up
            //Output Type      : IActionResult
            //                   - the view showing that board's details
            //
            var board = Repository.Boards.FirstOrDefault(b => b.BoardCode == boardCode);
            return View(board);
        } // end method
    } // end class
} // end namespace