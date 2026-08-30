// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Assessment 1
// Purpose         : Handles listing, viewing, creating, editing and
//                   deleting boards.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public ViewResult Index()
        {
            //
            //Name             : ViewResult Index()
            //Purpose          : Displays every board currently in the
            //                   repository
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : ViewResult
            //                   - the view listing all boards
            //
            return View(Repository.Boards);
        } // end method

        public ViewResult Details(string id)
        {
            //
            //Name             : ViewResult Details(string id)
            //Purpose          : Displays the details of a single board
            //                   matching the given board code
            //Re-use           : GetByBoardCode()
            //Input Parameters : string id
            //                   - the board code to look up
            //Output Type      : ViewResult
            //                   - the view showing that board's details
            //
            Board? board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Create()
        {
            //
            //Name             : ViewResult Create()
            //Purpose          : Displays the form used to capture a new
            //                   board
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : ViewResult
            //                   - the default Create view
            //
            return View();
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            //
            //Name             : ViewResult Create(Board board)
            //Purpose          : Receives data from the Create form. If the
            //                   submitted data is valid, adds the new
            //                   board to the repository and assigns a
            //                   success message.
            //Re-use           : Repository.AddBoard()
            //Input Parameters : Board board
            //                   - the board object created by the model
            //                     binder from the submitted form data
            //Output Type      : ViewResult
            //                   - the default Create view, with board
            //
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added.";
            } // end if
            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Edit(string id)
        {
            //
            //Name             : ViewResult Edit(string id)
            //Purpose          : Finds the board matching the given board
            //                   code and displays it in the Edit form
            //Re-use           : GetByBoardCode()
            //Input Parameters : string id
            //                   - the board code to look up
            //Output Type      : ViewResult
            //                   - the default Edit view
            //
            Board? board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            //
            //Name             : ViewResult Edit(Board board)
            //Purpose          : Receives data from the Edit form. If the
            //                   submitted data is valid, updates the
            //                   matching board in the repository and
            //                   assigns a success message.
            //Re-use           : Repository.UpdateBoard()
            //Input Parameters : Board board
            //                   - the board object created by the model
            //                     binder from the submitted form data
            //Output Type      : ViewResult
            //                   - the default Edit view, with board
            //
            if (ModelState.IsValid)
            {
                Repository.UpdateBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was updated.";
            } // end if
            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Delete(string id)
        {
            //
            //Name             : ViewResult Delete(string id)
            //Purpose          : Finds the board matching the given board
            //                   code and displays it for delete
            //                   confirmation
            //Re-use           : GetByBoardCode()
            //Input Parameters : string id
            //                   - the board code to look up
            //Output Type      : ViewResult
            //                   - the default Delete view
            //
            Board? board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            //
            //Name             : ViewResult Delete(Board board)
            //Purpose          : Removes the board matching the posted
            //                   board code from the repository and
            //                   assigns a success message
            //Re-use           : Repository.RemoveBoard()
            //Input Parameters : Board board
            //                   - the board object created by the model
            //                     binder, carrying only the board code
            //                     from the hidden input
            //Output Type      : ViewResult
            //                   - the default Delete view, with board
            //
            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";
            return View(board);
        } // end method
    } // end class
} // end namespace