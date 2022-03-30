using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Maps.Base;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    ///     Map of terms of payments.
    /// </summary>
    public class TermsOfPaymentMap : ClassMap<TermsOfPaymentRow.TermsOfPaymentRow>
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public TermsOfPaymentMap()
        {
            Map(row => row.Number, row => row.Number.ToDatev());
            Map(row => row.Name, row => row.Name.ToDatev());
            Map(row => row.DueType, row => row.DueType.ToDatev());
            Map(row => row.CashDiscount1Percent, row => row.CashDiscount1Percent.ToDatev());
            Map(row => row.CashDiscount1Days, row => row.CashDiscount1Days.ToDatev());
            Map(row => row.CashDiscount2Percent, row => row.CashDiscount2Percent.ToDatev());
            Map(row => row.CashDiscount2Days, row => row.CashDiscount2Days.ToDatev());
            Map(row => row.Days, row => row.Days.ToDatev());

            Map(row => row.Period1BillingDay, row =>  row.Period1BillingDay.ToDatev());
            Map(row => row.Period1CashDiscount1Day, row => row.Period1CashDiscount1Day.ToDatev());
            Map(row => row.Period1CashDiscount1Month, row => row.Period1CashDiscount1Month.ToDatev());
            Map(row => row.Period1CashDiscount2Day, row => row.Period1CashDiscount2Day.ToDatev());
            Map(row => row.Period1CashDiscount2Month, row => row.Period1CashDiscount2Month.ToDatev());
            Map(row => row.Period1DueDay, row => row.Period1DueDay.ToDatev());
            Map(row => row.Period1DueMonth, row => row.Period1DueMonth.ToDatev());

            Map(row => row.Period2BillingDay, row => row.Period2BillingDay.ToDatev());
            Map(row => row.Period2CashDiscount1Day, row => row.Period2CashDiscount1Day.ToDatev());
            Map(row => row.Period2CashDiscount1Month, row => row.Period2CashDiscount1Month.ToDatev());
            Map(row => row.Period2CashDiscount2Day, row => row.Period2CashDiscount2Day.ToDatev());
            Map(row => row.Period2CashDiscount2Month, row => row.Period2CashDiscount2Month.ToDatev());
            Map(row => row.Period2DueDay, row => row.Period2DueDay.ToDatev());
            Map(row => row.Period2DueMonth, row => row.Period2DueMonth.ToDatev());

            Map(row => row.Period3BillingDay, row => row.Period3BillingDay.ToDatev());
            Map(row => row.Period3CashDiscount1Day, row => row.Period3CashDiscount1Day.ToDatev());
            Map(row => row.Period3CashDiscount1Month, row => row.Period3CashDiscount1Month.ToDatev());
            Map(row => row.Period3CashDiscount2Day, row => row.Period3CashDiscount2Day.ToDatev());
            Map(row => row.Period3CashDiscount2Month, row => row.Period3CashDiscount2Month.ToDatev());
            Map(row => row.Period3DueDay, row => row.Period3DueDay.ToDatev());
            Map(row => row.Period3DueMonth, row => row.Period3DueMonth.ToDatev());
        }
    }
}