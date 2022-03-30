using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.TermsOfPaymentRow
{
    /// <summary>
    /// The terms of payment row.
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

        /// <summary>
        /// Gets or sets the period 1 billing day.
        /// </summary>
        ///
        /// <value>
        /// The period 1 billing day.
        /// </value>
        [DatevField(8, 1)]
        public int? Period1BillingDay { get; set; }

        /// <summary>
        /// Gets or sets the period 1 cash discount 1 day.
        /// </summary>
        ///
        /// <value>
        /// The period 1 cash discount 1 day.
        /// </value>
        [DatevField(9, 1)]
        public int? Period1CashDiscount1Day { get; set; }

        /// <summary>
        /// Gets or sets the period 1 cash discount 1 month.
        /// </summary>
        ///
        /// <value>
        /// The period 1 cash discount 1 month.
        /// </value>
        [DatevField(10, 1)]
        public MonthPick? Period1CashDiscount1Month { get; set; }

        /// <summary>
        /// Gets or sets the period 1 cash discount 2 day.
        /// </summary>
        ///
        /// <value>
        /// The period 1 cash discount 2 day.
        /// </value>
        [DatevField(11, 1)]
        public int? Period1CashDiscount2Day { get; set; }

        /// <summary>
        /// Gets or sets the period 1 cash discount 2 month.
        /// </summary>
        ///
        /// <value>
        /// The period 1 cash discount 2 month.
        /// </value>
        [DatevField(12, 1)]
        public MonthPick? Period1CashDiscount2Month { get; set; }

        /// <summary>
        /// Gets or sets the period 1 due day.
        /// </summary>
        ///
        /// <value>
        /// The period 1 due day.
        /// </value>
        [DatevField(13, 1)]
        public int? Period1DueDay { get; set; }

        /// <summary>
        /// Gets or sets the period 1 due month.
        /// </summary>
        ///
        /// <value>
        /// The period 1 due month.
        /// </value>
        [DatevField(14, 1)]
        public MonthPick? Period1DueMonth { get; set; }

        /// <summary>
        /// Gets or sets the period 2 billing day.
        /// </summary>
        ///
        /// <value>
        /// The period 2 billing day.
        /// </value>
        [DatevField(15, 1)]
        public int? Period2BillingDay { get; set; }

        /// <summary>
        /// Gets or sets the period 2 cash discount 1 day.
        /// </summary>
        ///
        /// <value>
        /// The period 2 cash discount 1 day.
        /// </value>
        [DatevField(16, 1)]
        public int? Period2CashDiscount1Day { get; set; }

        /// <summary>
        /// Gets or sets the period 2 cash discount 1 month.
        /// </summary>
        ///
        /// <value>
        /// The period 2 cash discount 1 month.
        /// </value>
        [DatevField(17, 1)]
        public MonthPick? Period2CashDiscount1Month { get; set; }

        /// <summary>
        /// Gets or sets the period 2 cash discount 2 day.
        /// </summary>
        ///
        /// <value>
        /// The period 2 cash discount 2 day.
        /// </value>
        [DatevField(18, 1)]
        public int? Period2CashDiscount2Day { get; set; }

        /// <summary>
        /// Gets or sets the period 2 cash discount 2 month.
        /// </summary>
        ///
        /// <value>
        /// The period 2 cash discount 2 month.
        /// </value>
        [DatevField(19, 1)]
        public MonthPick? Period2CashDiscount2Month { get; set; }

        /// <summary>
        /// Gets or sets the period 2 due day.
        /// </summary>
        ///
        /// <value>
        /// The period 2 due day.
        /// </value>
        [DatevField(20, 1)]
        public int? Period2DueDay { get; set; }

        /// <summary>
        /// Gets or sets the period 2 due month.
        /// </summary>
        ///
        /// <value>
        /// The period 2 due month.
        /// </value>
        [DatevField(21, 1)]
        public MonthPick? Period2DueMonth { get; set; }

        /// <summary>
        /// Gets or sets the period 3 billing day.
        /// </summary>
        ///
        /// <value>
        /// The period 3 billing day.
        /// </value>
        [DatevField(22, 1)]
        public int? Period3BillingDay { get; set; }

        /// <summary>
        /// Gets or sets the period 3 cash discount 1 day.
        /// </summary>
        ///
        /// <value>
        /// The period 3 cash discount 1 day.
        /// </value>
        [DatevField(23, 1)]
        public int? Period3CashDiscount1Day { get; set; }

        /// <summary>
        /// Gets or sets the period 3 cash discount 1 month.
        /// </summary>
        ///
        /// <value>
        /// The period 3 cash discount 1 month.
        /// </value>
        [DatevField(24, 1)]
        public MonthPick? Period3CashDiscount1Month { get; set; }

        /// <summary>
        /// Gets or sets the period 3 cash discount 2 day.
        /// </summary>
        ///
        /// <value>
        /// The period 3 cash discount 2 day.
        /// </value>
        [DatevField(25, 1)]
        public int? Period3CashDiscount2Day { get; set; }

        /// <summary>
        /// Gets or sets the period 3 cash discount 2 month.
        /// </summary>
        ///
        /// <value>
        /// The period 3 cash discount 2 month.
        /// </value>
        [DatevField(26, 1)]
        public MonthPick? Period3CashDiscount2Month { get; set; }

        /// <summary>
        /// Gets or sets the period 3 due day.
        /// </summary>
        ///
        /// <value>
        /// The period 3 due day.
        /// </value>
        [DatevField(27, 1)]
        public int? Period3DueDay { get; set; }

        /// <summary>
        /// Gets or sets the period 3 due month.
        /// </summary>
        ///
        /// <value>
        /// The period 3 due month.
        /// </value>
        [DatevField(28, 1)]
        public MonthPick? Period3DueMonth { get; set; }
    }
}