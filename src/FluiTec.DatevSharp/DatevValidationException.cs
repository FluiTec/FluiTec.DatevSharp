using System;
using FluentValidation.Results;

namespace FluiTec.DatevSharp
{
    /// <summary>   Exception for signalling datev validation errors. </summary>
    public class DatevValidationException : Exception
    {
        /// <summary>   Constructor. </summary>
        /// <param name="result">   The result. </param>
        /// <param name="message">  The message. </param>
        public DatevValidationException(ValidationResult result, string message) : base(message)
        {
            ValidationResult = result;
        }

        /// <summary>   Gets the validation result. </summary>
        /// <value> The validation result. </value>
        public ValidationResult ValidationResult { get; }
    }
}