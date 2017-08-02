using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;
using FluiTec.Datev.Models.Rows;
using FluiTec.Datev.Models.Validators;

namespace FluiTec.Datev.Models
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
				throw new DatevValidationException(validationResult, message: "Invalid DATEV-File.");

			var sb = new StringBuilder();
			sb.Append(Header.ToRow());
			sb.Append(Environment.NewLine + DataCategories.GetHeaderRow(Header.DataCategory).ToRow());
			foreach (var row in Rows)
				sb.Append(Environment.NewLine + row.ToRow());
			return sb.ToString();
		}

		#endregion
	}
}