namespace FluiTec.DatevSharp.Formats.Serialization
{
    /// <summary>
    ///     A field.
    /// </summary>
    public class Field
    {
        /// <summary>
        ///     Gets or sets the identifier of the field.
        /// </summary>
        /// <value>
        ///     The identifier of the field.
        /// </value>
        public int FieldId { get; set; }

        /// <summary>
        ///     Gets or sets the identifier of the display group.
        /// </summary>
        /// <value>
        ///     The identifier of the display group.
        /// </value>
        public int DisplayGroupId { get; set; }

        /// <summary>
        ///     Gets or sets the ordinal number.
        /// </summary>
        /// <value>
        ///     The ordinal number.
        /// </value>
        public int OrdinalNumber { get; set; }

        /// <summary>
        ///     Gets or sets the label.
        /// </summary>
        /// <value>
        ///     The label.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        ///     Gets or sets the label alias.
        /// </summary>
        /// <value>
        ///     The label alias.
        /// </value>
        public string LabelAlias { get; set; }

        /// <summary>
        ///     Gets or sets the importable.
        /// </summary>
        /// <value>
        ///     The importable.
        /// </value>
        public int Importable { get; set; }

        /// <summary>
        ///     Gets or sets the exportable.
        /// </summary>
        /// <value>
        ///     The exportable.
        /// </value>
        public int Exportable { get; set; }

        /// <summary>
        ///     Gets or sets the length.
        /// </summary>
        /// <value>
        ///     The length.
        /// </value>
        public int Length { get; set; }

        /// <summary>
        ///     Gets or sets the decimal places.
        /// </summary>
        /// <value>
        ///     The decimal places.
        /// </value>
        public int DecimalPlaces { get; set; }

        /// <summary>
        ///     Gets or sets the type of the format.
        /// </summary>
        /// <value>
        ///     The type of the format.
        /// </value>
        public string FormatType { get; set; }

        /// <summary>
        ///     Gets or sets the necessary.
        /// </summary>
        /// <value>
        ///     The necessary.
        /// </value>
        public int Necessary { get; set; }

        /// <summary>
        ///     Gets or sets the is formatable.
        /// </summary>
        /// <value>
        ///     The is formatable.
        /// </value>
        public int IsFormatable { get; set; }

        /// <summary>
        ///     Gets or sets the decimals editable.
        /// </summary>
        /// <value>
        ///     The decimals editable.
        /// </value>
        public int DecimalsEditable { get; set; }

        /// <summary>
        ///     Gets or sets the grouping symbol.
        /// </summary>
        /// <value>
        ///     The grouping symbol.
        /// </value>
        public int GroupingSymbol { get; set; }

        /// <summary>
        ///     Gets or sets the credit debit sign.
        /// </summary>
        /// <value>
        ///     The credit debit sign.
        /// </value>
        public int CreditDebitSign { get; set; }

        /// <summary>
        ///     Gets or sets the identifier of the base field.
        /// </summary>
        /// <value>
        ///     The identifier of the base field.
        /// </value>
        public int BaseFieldId { get; set; }

        /// <summary>
        ///     Gets or sets the fixed length.
        /// </summary>
        /// <value>
        ///     The length of the fixed.
        /// </value>
        public int FixedLength { get; set; }

        /// <summary>
        ///     Gets or sets the add credit debit sign.
        /// </summary>
        /// <value>
        ///     The add credit debit sign.
        /// </value>
        public int AddCreditDebitSign { get; set; }

        /// <summary>
        ///     Gets or sets the number of maximums.
        /// </summary>
        /// <value>
        ///     The number of maximums.
        /// </value>
        public int MaxCount { get; set; }

        /// <summary>
        ///     Gets or sets the calculation rule.
        /// </summary>
        /// <value>
        ///     The calculation rule.
        /// </value>
        public string CalculationRule { get; set; }
    }
}