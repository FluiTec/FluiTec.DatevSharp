using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using FluiTec.DatevSharp.Formats.Serialization;
using Newtonsoft.Json;

namespace FluiTec.DatevSharp
{
    /// <summary>
    /// A data category version.
    /// </summary>
    public class DataCategoryVersion
    {
        private XDocument _formatDocument;
        private FormatDescription _formatDescription;

        /// <summary>
        /// Gets the version.
        /// </summary>
        ///
        /// <value>
        /// The version.
        /// </value>
        public int Version { get; }

        /// <summary>
        /// Gets the datev version.
        /// </summary>
        ///
        /// <value>
        /// The datev version.
        /// </value>
        public int DatevVersion { get; }

        /// <summary>
        /// Gets the file.
        /// </summary>
        ///
        /// <value>
        /// The file.
        /// </value>
        public string File { get; }

        /// <summary>
        /// Gets the format document.
        /// </summary>
        ///
        /// <exception cref="InvalidOperationException">    Thrown when the requested operation is
        ///                                                 invalid. </exception>
        ///
        /// <value>
        /// The format document.
        /// </value>
        public XDocument FormatDocument
        {
            get
            {
                if (_formatDocument != null) return _formatDocument;

                var asm = typeof(DataCategories).Assembly;
                using (var mapResource = asm.GetManifestResourceStream(File))
                using (var sr = new StreamReader(mapResource ?? throw new InvalidOperationException()))
                {
                    var xml = sr.ReadToEnd();
                    _formatDocument = XDocument.Parse(xml);
                }

                return _formatDocument;
            }
        }

        /// <summary>
        /// Gets information describing the format.
        /// </summary>
        ///
        /// <value>
        /// Information describing the format.
        /// </value>
        public FormatDescription FormatDescription
        {
            get
            {
                if (_formatDescription != null) return _formatDescription;

                var serializer = new XmlSerializer(typeof(FormatDescription));
                _formatDescription = (FormatDescription)serializer.Deserialize(FormatDocument.CreateReader());

                return _formatDescription;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="version">      The version. </param>
        /// <param name="datevVersion"> The datev version. </param>
        /// <param name="file">         The file. </param>
        [JsonConstructor]
        [Obsolete("Must only be used by the JSON.NET!")]
        public DataCategoryVersion(int version, int datevVersion, string file)
        {
            Version = version;
            DatevVersion = datevVersion;
            File = file;
        }
    }
}