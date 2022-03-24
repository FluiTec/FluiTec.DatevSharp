using System;
using Newtonsoft.Json;

namespace FluiTec.DatevSharp
{
    /// <summary>
    /// A data category version.
    /// </summary>
    public class DataCategoryVersion
    {
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