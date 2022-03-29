namespace FluiTec.DatevSharp.Formats.Serialization
{
    /// <summary>
    ///     A format.
    /// </summary>
    public class Format
    {
        /// <summary>
        ///     Gets or sets the identifier of the format.
        /// </summary>
        /// <value>
        ///     The identifier of the format.
        /// </value>
        public int FormatId { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the type of the standard.
        /// </summary>
        /// <value>
        ///     The type of the standard.
        /// </value>
        public int StandardType { get; set; }

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
        ///     Gets or sets the category the data belongs to.
        /// </summary>
        /// <value>
        ///     The data category.
        /// </value>
        public string DataCategory { get; set; }

        /// <summary>
        ///     Gets or sets the group seperator.
        /// </summary>
        /// <value>
        ///     The group seperator.
        /// </value>
        public string GroupSeperator { get; set; }

        /// <summary>
        ///     Gets or sets the decimal seperator.
        /// </summary>
        /// <value>
        ///     The decimal seperator.
        /// </value>
        public string DecimalSeperator { get; set; }

        /// <summary>
        ///     Gets or sets the date format expression.
        /// </summary>
        /// <value>
        ///     The date format expression.
        /// </value>
        public string DateFormatExpression { get; set; }

        /// <summary>
        ///     Gets or sets the date format seperator.
        /// </summary>
        /// <value>
        ///     The date format seperator.
        /// </value>
        public object DateFormatSeperator { get; set; }

        /// <summary>
        ///     Gets or sets the currency sign expression.
        /// </summary>
        /// <value>
        ///     The currency sign expression.
        /// </value>
        public string CurrencySignExpression { get; set; }

        /// <summary>
        ///     Gets or sets the pathname of the directory.
        /// </summary>
        /// <value>
        ///     The pathname of the directory.
        /// </value>
        public object DirectoryName { get; set; }

        /// <summary>
        ///     Gets or sets the filename of the file.
        /// </summary>
        /// <value>
        ///     The name of the file.
        /// </value>
        public object FileName { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>
        ///     The version.
        /// </value>
        public int Version { get; set; }

        /// <summary>
        ///     Gets or sets the is default format.
        /// </summary>
        /// <value>
        ///     The is default format.
        /// </value>
        public int IsDefaultFormat { get; set; }

        /// <summary>
        ///     Gets or sets the data extended zone.
        /// </summary>
        /// <value>
        ///     The data extended zone.
        /// </value>
        public string DataExtendedZone { get; set; }
    }
}