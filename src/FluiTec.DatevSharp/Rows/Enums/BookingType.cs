using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Enums
{
    /// <summary>
    ///     Values that represent booking types.
    /// </summary>
    public enum BookingType
    {
        [StringValue(null)] Undefined,
        [StringValue("AA")] RequestedCommission,
        [StringValue("AG")] ReceivedCommission,
        [StringValue("AV")] ReceivedObligation,
        [StringValue("SR")] FinalInvoice,
        [StringValue("SU")] FinalInvoiceReclassification,
        [StringValue("SG")] FinalInvoiceCommission,
        [StringValue("SO")] Other
    }
}