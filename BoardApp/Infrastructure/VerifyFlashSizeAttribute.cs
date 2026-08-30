/// Programmer name : Zenande Silinga; Phiwe Bunu; Rethabile Mosoeu
// Student nr      : 225094388;225024254;222078921
// Assignment nr   : Practical Assessment 1
// Purpose         : Custom validation attribute that checks a flash
//                   size value against the fixed list of real-world
//                   flash sizes, since [Range] cannot express
//                   membership of a specific list of values.

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BoardApp.Infrastructure
{
    public class VerifyFlashSizeAttribute : Attribute, IModelValidator
    {
        public bool IsRequired => true;

        public string ErrorMessage { get; set; } = "Valid flash sizes in KB are: 16, 32, 64, 128, 256, 512, 1024, 2048, 4096";

        // Valid flash sizes in KB
        private readonly List<int> validFlashSizes = new List<int>
        {
            16, 32, 64, 128, 256, 512, 1024, 2048, 4096
        };

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            //
            //Name             : IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
            //Purpose          : Checks that the submitted flash size value
            //                   is present and matches one of the fixed
            //                   list of valid flash sizes
            //Re-use           : None
            //Input Parameters : ModelValidationContext context
            //                   - supplies the value being validated
            //Output Type      : IEnumerable<ModelValidationResult>
            //                   - an error result if invalid, or an empty
            //                     collection if valid
            //
            int? value = context.Model as int?;

            // Fail if null or not in the allowed set
            if (value == null || !validFlashSizes.Contains(value.Value))
            {
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult("", ErrorMessage)
                };
            } // end if

            // Pass if valid
            return Enumerable.Empty<ModelValidationResult>();
        } // end method
    } // end class
} // end namespace