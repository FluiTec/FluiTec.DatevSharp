namespace FluiTec.DatevSharp.Formats.Serialization
{
    /// <summary>
    /// A CSV format properties.
    /// </summary>
    public class CsvFormatProperties
    {
        /// <summary>
        /// Gets or sets the identifier of the CSV format properties.
        /// </summary>
        ///
        /// <value>
        /// The identifier of the CSV format properties.
        /// </value>
        public int CsvFormatPropertiesId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the format.
        /// </summary>
        ///
        /// <value>
        /// The identifier of the format.
        /// </value>
        public int FormatId { get; set; }

        /// <summary>
        /// Gets or sets the seperator field.
        /// </summary>
        ///
        /// <value>
        /// The seperator field.
        /// </value>
        public string SeperatorField { get; set; }

        /// <summary>
        /// Gets or sets the seperator text.
        /// </summary>
        ///
        /// <value>
        /// The seperator text.
        /// </value>
        public string SeperatorText { get; set; }

        /// <summary>
        /// Gets or sets the double text seperator.
        /// </summary>
        ///
        /// <value>
        /// The double text seperator.
        /// </value>
        public int DoubleTextSeperator { get; set; }

        /// <summary>
        /// Gets or sets the layout style.
        /// </summary>
        ///
        /// <value>
        /// The layout style.
        /// </value>
        public string LayoutStyle { get; set; }

        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        ///
        /// <value>
        /// The alignment.
        /// </value>
        public string Alignment { get; set; }

        /// <summary>
        /// Gets or sets the coding.
        /// </summary>
        ///
        /// <value>
        /// The coding.
        /// </value>
        public string Coding { get; set; }

        /// <summary>
        /// Gets or sets the row from.
        /// </summary>
        ///
        /// <value>
        /// The row from.
        /// </value>
        public int RowFrom { get; set; }

        /// <summary>
        /// Gets or sets the row to.
        /// </summary>
        ///
        /// <value>
        /// The row to.
        /// </value>
        public int RowTo { get; set; }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        ///
        /// <value>
        /// The header.
        /// </value>
        public int Header { get; set; }

        /// <summary>
        /// Gets or sets the headline.
        /// </summary>
        ///
        /// <value>
        /// The headline.
        /// </value>
        public int Headline { get; set; }

        /// <summary>
        /// Gets or sets the end line with seperator text.
        /// </summary>
        ///
        /// <value>
        /// The end line with seperator text.
        /// </value>
        public int EndLineWithSeperatorText { get; set; }
    }
}