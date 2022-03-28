using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Maps.Base;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    /// Map of terms of payments.
    /// </summary>
    public class TermsOfPaymentMap : ClassMap<TermsOfPaymentRow.TermsOfPaymentRow>
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public TermsOfPaymentMap()
        {
            Map(row => row.Number, row => row.Number.ToDatev());
            Map(row =>  row.Name, row => row.Name.ToDatev());
            Map(row => row.DueType, row => row.DueType.ToDatev());
            Map(row => row.CashDiscount1Percent, row => row.CashDiscount1Percent.ToDatev());
            Map(row => row.CashDiscount1Days, row => row.CashDiscount1Days.ToDatev());
            Map(row => row.CashDiscount2Percent, row => row.CashDiscount2Percent.ToDatev());
            Map(row => row.CashDiscount2Days, row => row.CashDiscount2Days.ToDatev());
            Map(row => row.Days, row => row.Days.ToDatev());
        }
    }
}