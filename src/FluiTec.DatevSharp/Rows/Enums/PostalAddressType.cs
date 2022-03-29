using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Enums
{
    /// <summary>
    /// Values that represent postal address types.
    /// </summary>
    public enum PostalAddressType
    {
        [StringValue("STR")]
        Street,
        [StringValue("PF")]
        PostBox,
        [StringValue("GK")]
        MajorCustomer
    }
}