using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Enums
{
    /// <summary>
    /// Values that represent claim types.
    /// </summary>
    public enum Claim
    {
        [StringValue("S")]
        Debit,
        [StringValue("H")]
        Credit
    }
}