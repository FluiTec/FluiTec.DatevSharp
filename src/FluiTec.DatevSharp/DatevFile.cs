using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentValidation;
using FluentValidation.Results;
using FluiTec.DatevSharp.Helpers;
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
            sb.Append(Environment.NewLine + GetHeaderRow(Header.DataCategory.RowType).ToRow(Header.DataVersion));
            var map = Header.DataCategory.RowType.GetDatevMetadata().GetMap();
            foreach (var row in Rows)
            {
                sb.AppendLine();
                foreach (var field in Header.DataVersion.FormatDescription.Fields.OrderBy(f => f.OrdinalNumber))
                {
                    var memberMap = map.FindByOrdinalNumber(field.OrdinalNumber);
                    sb.Append(memberMap != null ? $"{memberMap.DatevOutput(row)};" :
                        field.FormatType == "Text" ? "\"\";" : ";");
                }

                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }


        /// <summary>   Gets the name of the file. </summary>
        /// <returns>   The name of the file. </returns>
        /// <remarks>
        ///     To adhere to the standard - the file must be named accordingly.
        ///     This method returns a name in the following format:
        ///     $"EXTF_{Header.DataCategory.Name}_{Header.Created:yyyy_MM_dd_HH_mm_ss}.csv".Replace("/", "_");
        /// </remarks>
        public string GetName()
        {
            return $"EXTF_{Header.DataCategory.DatevName}_{Header.Created:yyyy_MM_dd_HH_mm_ss}.csv".Replace("/", "_");
        }

        /// <summary>   Gets the validator needed for the given format. </summary>
        /// <returns>   The validator for the given format. </returns>
        public IValidator<IDatevRow> GetValidator()
        {
            if (Header.DataCategory == null)
                throw new NoNullAllowedException(
                    $"{nameof(DataCategory)} must not be null for this method to succeed.");
            if (Header.DataCategory.Number == DataCategories.Instance.BookingCategory.Number)
                return new BookingRowValidator(Header.ImpersonalAccountsLength);
            if (Header.DataCategory.Number == DataCategories.Instance.AddressCategory.Number)
                return new AddressRowValidator(Header.ImpersonalAccountsLength + 1);
            if (Header.DataCategory.Number == DataCategories.Instance.TermsOfPaymentCategory.Number)
                return new TermsOfPaymentRowValidator();

            throw new ArgumentException(
                $"{nameof(DataCategory)} with value {Header.DataCategory.Number} is not implemented yet.");
        }

        /// <summary>
        ///     Gets header row.
        /// </summary>
        /// <param name="rowType">  Type of the row. </param>
        /// <returns>
        ///     The header row.
        /// </returns>
        public static IVersionDatevRow GetHeaderRow(Type rowType)
        {
            return rowType.GetDatevMetadata().GetHeader();
        }

        #endregion
    }
}