namespace FluiTec.DatevSharp.Rows.Enums
{
    /// <summary>
    /// Values that represent payment transfer mediums.
    /// </summary>
    public enum PaymentTransferMedium
    {
        Empty = 0,
        SingleCheck = 5,
        CollectiveCheck = 6,
        SepaPerInvoice = 7,
        CollectiveSepa = 8,
        None = 9
    }
}