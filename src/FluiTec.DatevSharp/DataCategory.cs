using System;
using System.Linq;
using Newtonsoft.Json;

namespace FluiTec.DatevSharp
{
    /// <summary>
    ///     A data category.
    /// </summary>
    public class DataCategory
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="number">               The number. </param>
        /// <param name="name">                 The name. </param>
        /// <param name="datevName">            The name of the datev. </param>
        /// <param name="rowType">              The type of the row. </param>
        /// <param name="defaultVersionNumber"> The default version number. </param>
        /// <param name="versions">             The versions. </param>
        [JsonConstructor]
        [Obsolete("Must only be used by the JSON.NET!")]
        public DataCategory(int number, string name, string datevName, Type rowType, int defaultVersionNumber,
            DataCategoryVersion[] versions)
        {
            Number = number;
            Name = name;
            DatevName = datevName;
            RowType = rowType;
            DefaultVersionNumber = defaultVersionNumber;
            Versions = versions;
        }

        /// <summary>   Gets or sets the name. </summary>
        /// <value> The name. </value>
        public string Name { get; }

        /// <summary>
        ///     Gets the name of the datev.
        /// </summary>
        /// <value>
        ///     The name of the datev.
        /// </value>
        public string DatevName { get; }

        /// <summary>
        ///     Gets or sets the type of the row.
        /// </summary>
        /// <value>
        ///     The type of the row.
        /// </value>
        public Type RowType { get; internal set; }

        /// <summary>   Gets or sets the number.  </summary>
        /// <value> The number. </value>
        public int Number { get; }

        /// <summary>
        ///     Gets the default version number.
        /// </summary>
        /// <value>
        ///     The default version number.
        /// </value>
        public int DefaultVersionNumber { get; }

        /// <summary>
        ///     Gets the default version.
        /// </summary>
        /// <value>
        ///     The default version.
        /// </value>
        public DataCategoryVersion DefaultVersion => Versions.Single(v => v.Version == DefaultVersionNumber);

        /// <summary>
        ///     Gets the versions.
        /// </summary>
        /// <value>
        ///     The versions.
        /// </value>
        public DataCategoryVersion[] Versions { get; }
    }
}