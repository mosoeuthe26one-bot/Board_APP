// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Assessment 1
// Purpose         : This class provides temporary in-memory storage for
//                   Board objects, acting as a stand-in repository.

using System.Collections.Generic;
using System.Linq;

namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();

        static Repository()
        {
            //
            //Name             : static Repository()
            //Purpose          : Static constructor that seeds the repository
            //                   with ten sample boards when the class is first
            //                   used
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : None
            //
            boards = new List<Board>()
            {
                new Board("1001", "Espressif", "ESP32-WROOM-32", 4096, 129.00m),
                new Board("1002", "Espressif", "ESP32-C3-MINI-1", 4096, 99.00m),
                new Board("1003", "STMicroelectronics", "STM32F103C8T6", 64, 75.00m),
                new Board("1004", "STMicroelectronics", "STM32F411CEU6", 512, 145.00m),
                new Board("1005", "Microchip", "ATmega328P", 32, 89.00m),
                new Board("1006", "Microchip", "ATmega2560", 256, 199.00m),
                new Board("1007", "WCH", "CH32V003F4P6", 16, 29.00m),
                new Board("1008", "Raspberry Pi", "Pico", 2048, 89.00m),
                new Board("1009", "Espressif", "ESP-01S", 1024, 65.00m),
                new Board("1010", "CUTfree", "CV32-BFN-01", 128, 49.00m)
            };
        } // end method

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

        public static Board? GetByBoardCode(string boardCode)
        {
            //
            //Name             : Board? GetByBoardCode(string boardCode)
            //Purpose          : Finds and returns the board matching the
            //                   given board code
            //Re-use           : None
            //Input Parameters : string boardCode
            //                   - the board code to search for
            //Output Type      : Board?
            //                   - the matching board if found, otherwise
            //                     null
            //
            return boards.FirstOrDefault(b => b.BoardCode == boardCode);
        } // end method

        public static void RemoveBoard(string boardCode)
        {
            //
            //Name             : void RemoveBoard(string boardCode)
            //Purpose          : Removes the board matching the given
            //                   board code from the repository
            //Re-use           : GetByBoardCode()
            //Input Parameters : string boardCode
            //                   - the board code of the board to remove
            //Output Type      : None
            //
            Board? board = GetByBoardCode(boardCode);
            boards.Remove(board);
        } // end method

        public static void UpdateBoard(Board updatedBoard)
        {
            //
            //Name             : void UpdateBoard(Board updatedBoard)
            //Purpose          : Updates the Make, Model, FlashKb and Price
            //                   of an existing board, found by board code.
            //                   BoardCode itself is never updated, since
            //                   it is the board's identity.
            //Re-use           : GetByBoardCode()
            //Input Parameters : Board updatedBoard
            //                   - a board object containing the updated
            //                     values
            //Output Type      : None
            //
            Board? board = GetByBoardCode(updatedBoard.BoardCode);
            board.Make = updatedBoard.Make;
            board.Model = updatedBoard.Model;
            board.FlashKb = updatedBoard.FlashKb;
            board.Price = updatedBoard.Price;
        } // end method
    } // end class
} // end namespace