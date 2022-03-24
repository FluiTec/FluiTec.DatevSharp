using System.Collections.Generic;
using System.Xml.Serialization;

namespace FluiTec.DatevSharp.Formats.Serialization
{
    /// <summary>
    /// Description of the format.
    /// </summary>
    public class FormatDescription
    {
        /// <summary>
        /// Gets or sets the format to use.
        /// </summary>
        ///
        /// <value>
        /// The format.
        /// </value>
        public Format Format { get; set; }

        [XmlElement(ElementName = "Field")]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets the CSV format properties.
        /// </summary>
        ///
        /// <value>
        /// The CSV format properties.
        /// </value>
        public CsvFormatProperties CsvFormatProperties { get; set; }
    }
}