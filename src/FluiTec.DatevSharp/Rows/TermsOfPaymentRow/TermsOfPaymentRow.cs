﻿using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.TermsOfPaymentRow
{
    /// <summary>
    ///     The terms of payment row.
    /// </summary>
    [DatevRow(typeof(TermsOfPaymentMap), typeof(HeaderRow))]
    public class TermsOfPaymentRow : IDatevRow
    {
        /// <summary>   Gets or sets the number of.  </summary>
        /// <value> The number. </value>
        /// <remarks>
        ///     MaxLength=3, MinLength=2
        /// </remarks>
        [DatevField(0, 1)]
        public int Number { get; set; }

        /// <summary>   Gets or sets the name. </summary>
        /// <value> The name. </value>
        [DatevField(1, 1)]
        public string Name { get; set; }

        /// <summary>   Gets or sets the type of the due. </summary>
        /// <value> The type of the due. </value>
        [DatevField(2, 1)]
        public DueType DueType { get; set; }

        /// <summary>   Gets or sets the cash discount 1 percent. </summary>
        /// <value> The cash discount 1 percent. </value>
        /// <remarks>
        ///     MaxLength=2 + 2 NKS
        /// </remarks>
        [DatevField(3, 1)]
        public int? CashDiscount1Percent { get; set; }

        /// <summary>   Gets or sets the cash discount 1 days. </summary>
        /// <value> The cash discount 1 days. </value>
        /// <remarks>
        ///     MaxLength=3
        /// </remarks>
        [DatevField(4, 1)]
        public int? CashDiscount1Days { get; set; }

        /// <summary>   Gets or sets the cash discount 2 percent. </summary>
        /// <value> The cash discount 2 percent. </value>
        /// <remarks>
        ///     MaxLength=2 + 2 NKS
        /// </remarks>
        [DatevField(5, 1)]
        public int? CashDiscount2Percent { get; set; }

        /// <summary>   Gets or sets the cash discount 2 days. </summary>
        /// <value> The cash discount 2 days. </value>
        /// <remarks>
        ///     MaxLength=3
        /// </remarks>
        [DatevField(6, 1)]
        public int? CashDiscount2Days { get; set; }

        /// <summary>   Gets or sets the days. </summary>
        /// <value> The days. </value>
        [DatevField(7, 1)]
        public int? Days { get; set; }
    }
}