using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Enums
{
    /// <summary>
    /// Values that represent taxation types.
    /// </summary>
    public enum TaxationType
    {
        [StringValue("I")]
        Actual,
        [StringValue("K")]
        None,
        [StringValue("P")]
        Flat,
        [StringValue("S")]
        Should
    }
}