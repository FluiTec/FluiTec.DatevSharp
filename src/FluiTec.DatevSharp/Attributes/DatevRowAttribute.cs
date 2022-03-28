using System;
using FluentValidation;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Attributes
{
    /// <summary>
    /// Attribute for datev row.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DatevRowAttribute : Attribute
    {
        /// <summary>
        /// Gets the type of the map.
        /// </summary>
        ///
        /// <value>
        /// The type of the map.
        /// </value>
        public Type MapType { get; }

        /// <summary>
        /// Gets the type of the header.
        /// </summary>
        ///
        /// <value>
        /// The type of the header.
        /// </value>
        public Type HeaderType { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <exception cref="ArgumentNullException">    Thrown when one or more required arguments are
        ///                                             null. </exception>
        /// <exception cref="ArgumentException">        Thrown when one or more arguments have
        ///                                             unsupported or illegal values. </exception>
        ///
        /// <param name="mapType">          Type of the map. </param>
        /// <param name="headerType">       The type of the header. </param>
        public DatevRowAttribute(Type mapType, Type headerType)
        {
            if (mapType == null) throw new ArgumentNullException(nameof(mapType));
            if (!typeof(IClassMap).IsAssignableFrom(mapType)) 
                throw new ArgumentException("MapType must inherit IClassMap!");
            MapType = mapType;

            if (headerType == null) throw new ArgumentNullException(nameof(headerType));
            if (!typeof(IVersionDatevRow).IsAssignableFrom(headerType))
                throw new ArgumentException("HeaderType must inherit IVersionDatevRow!");
            HeaderType = headerType;
        }

        /// <summary>
        /// Gets the map.
        /// </summary>
        ///
        /// <returns>
        /// The map.
        /// </returns>
        public IClassMap GetMap()
        {
            return (IClassMap) Activator.CreateInstance(MapType);
        }

        /// <summary>
        /// Gets the header.
        /// </summary>
        ///
        /// <returns>
        /// The header.
        /// </returns>
        public IVersionDatevRow GetHeader()
        {
            return (IVersionDatevRow) Activator.CreateInstance(HeaderType);
        }
    }
}