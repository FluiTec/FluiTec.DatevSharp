using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Validation;

namespace FluiTec.DatevSharp
{
	/// <summary>   A datev file. </summary>
	public class DatevFile
	{
		#region Constructors

		/// <summary>   Default constructor. </summary>
		public DatevFile()
		{
			Rows = new List<IDatevRow>();
		}

		#endregion

		#region Properties

		/// <summary>   Gets or sets the header. </summary>
		/// <value> The header. </value>
		public DatevHeader Header { get; set; }

		/// <summary>   Gets or sets the rows. </summary>
		/// <value> The rows. </value>
		public IList<IDatevRow> Rows { get; }

		#endregion

		#region Methods

		/// <summary>   Gets the validationResult. </summary>
		/// <returns>   A ValidationResult. </returns>
		private ValidationResult Validate()
		{
			var validator = new DatevFileValidator();
			return validator.Validate(this);
		}

		/// <summary>   Converts this object to a datev-string. </summary>
		/// <exception cref="DatevValidationException">
		///     Thrown when a Datev Validation error condition
		///     occurs.
		/// </exception>
		/// <returns>   This object as a datev-string. </returns>
		public string ToDatev()
		{
			var validationResult = Validate();
			if (!validationResult.IsValid)
				throw new DatevValidationException(validationResult, "Invalid DATEV-File.");

			var sb = new StringBuilder();
			sb.Append(Header.ToRow());
			sb.Append(Environment.NewLine + DataCategories.GetHeaderRow(Header.DataCategory).ToRow());
			foreach (var row in Rows)
				sb.Append(Environment.NewLine + row.ToRow());
			return sb.ToString();
		}


        /// <summary>   Gets the name of the file. </summary>
        /// <returns>   The name of the file. </returns>
        /// <remarks>
        /// To adhere to the standard - the file must be named accordingly.
        /// This method returns a name in the following format:
        /// $"EXTF_{Header.DataCategory.Name}_{Header.Created:yyyy_MM_dd_HH_mm_ss}.csv".Replace("/", "_");
        /// </remarks>
	    public string GetName()
	    {
            return $"EXTF_{Header.DataCategory.Name}_{Header.Created:yyyy_MM_dd_HH_mm_ss}.csv".Replace("/", "_");
        }

		#endregion
	}
}