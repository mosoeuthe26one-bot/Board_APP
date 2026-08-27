// Programmer name : Rethabile
// Student nr      : <YOUR STUDENT NUMBER HERE>
// Assignment nr   : Practical Worksheet 1
// Purpose         : This class provides temporary in-memory storage for
//                   Board objects, acting as a stand-in repository until
//                   a real database is introduced later in the module.

using System.Collections.Generic;

namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();

        public static IEnumerable<Board> Boards
        {
            //
            //Name            : property IEnumerable<Board> Boards
            //Purpose         : Public read-only property to give access to
            //                  the private boards field
            //Re-use          : none
            //Input Parameter : none
            //Output Type     : IEnumerable<Board>
            //                  - the collection of boards currently held
            //                    in the repository
            //
            get
            {
                return boards;
            } // end get
        } // end property

        public static void AddBoard(Board board)
        {
            //
            //Name             : void AddBoard(Board board)
            //Purpose          : Adds a new board to the in-memory
            //                   repository
            //Re-use           : None
            //Input Parameters : Board board
            //                   - the board object to add to the
            //                     repository
            //Output Type      : None
            //
            boards.Add(board);
        } // end method
    } // end class
} // end namespace