// Programmer name : Rethabile
// Student nr      : <YOUR STUDENT NUMBER HERE>
// Assignment nr   : Practical Worksheet 1
// Purpose         : This class represents a microcontroller development
//                   board, storing its board code, manufacturer, model,
//                   flash size and price.

using System;
using System.ComponentModel.DataAnnotations;

namespace BoardApp.Models
{
    public class Board
    {
        [Key]
        [Required(ErrorMessage = "The board code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The board code must have a length of 4.")]
        [Display(Name = "Board code")]
        public string BoardCode
        {
            //
            //Name            : property string BoardCode
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : string
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        [Required(ErrorMessage = "The board manufacturer is required.")]
        [Display(Name = "Manufacturer")]
        public string Make
        {
            //
            //Name            : property string Make
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : string
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        [Required(ErrorMessage = "The board model is required.")]
        [Display(Name = "Model")]
        public string Model
        {
            //
            //Name            : property string Model
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : string value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : string
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        [Required(ErrorMessage = "The flash size is required.")]
        [Range(16, 4096, ErrorMessage = "The flash size must be between 16 and 4096 inclusive.")]
        [Display(Name = "Flash (KB)")]
        public int? FlashKb
        {
            //
            //Name            : property int FlashKb
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : int value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : int
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        [Required(ErrorMessage = "The price is required.")]
        [Range(1.00, 5000.00, ErrorMessage = "The price must be between R1.00 and R5000.00 inclusive.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Price (R)")]
        public decimal? Price
        {
            //
            //Name            : property decimal Price
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : decimal value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : decimal
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        public Board()
        {
            //
            //Name             : Board()
            //Purpose          : Default empty constructor, required so the
            //                   MVC model binder can create an empty Board
            //                   instance before populating its properties
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : None
            //
        } // end method

        public Board(string boardCode, string make, string model, int flashKb, decimal price)
        {
            //
            //Name             : Board(string boardCode, string make, string
            //                   model, int flashKb, decimal price)
            //Purpose          : Overloaded constructor used to populate all
            //                   instance properties when a board is created
            //Re-use           : None
            //Input Parameters : string boardCode
            //                   - new value for BoardCode property
            //                   string make
            //                   - new value for Make property
            //                   string model
            //                   - new value for Model property
            //                   int flashKb
            //                   - new value for FlashKb property
            //                   decimal price
            //                   - new value for Price property
            //Output Type      : None
            //
            BoardCode = boardCode;
            Make = make;
            Model = model;
            FlashKb = flashKb;
            Price = price;
        } // end method

        public override string ToString()
        {
            //
            //Name             : string ToString()
            //Purpose          : Returns a formatted string describing this
            //                   board, including its code, manufacturer,
            //                   model, flash size and price
            //Re-use           : None
            //Input Parameters : None
            //Output Type      : string
            //                   - the formatted description of the board
            //
            return $"{BoardCode}: {Make} {Model} with {FlashKb} KB flash at R{Price:0.00}";
        } // end method
    } // end class
} // end namespace