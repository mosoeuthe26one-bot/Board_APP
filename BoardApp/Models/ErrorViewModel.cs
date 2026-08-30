// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Assessment 1
// Purpose         : Model used by the Error view to display a request
//                   identifier when an unhandled error occurs.

namespace BoardApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId
        {
            //
            //Name            : property string? RequestId
            //Purpose         : Automatic public property to give access to
            //                  corresponding compiler generated field
            //Re-use          : none
            //Input Parameter : string? value
            //                  - new value for corresponding compiler
            //                    generated field
            //Output Type     : string?
            //                  - value stored in the corresponding compiler
            //                    generated field
            //
            get; set;
        } // end property

        public bool ShowRequestId
        {
            //
            //Name            : property bool ShowRequestId
            //Purpose         : Indicates whether RequestId has a value
            //                  worth displaying
            //Re-use          : none
            //Input Parameter : none
            //Output Type     : bool
            //                  - true if RequestId is not null or empty,
            //                    otherwise false
            //
            get
            {
                return !string.IsNullOrEmpty(RequestId);
            } // end get
        } // end property
    } // end class
} // end namespace