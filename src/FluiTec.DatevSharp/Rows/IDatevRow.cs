namespace FluiTec.DatevSharp.Rows
{
	/// <summary>   Interface for datev row. </summary>
	public interface IDatevRow
	{
		/// <summary>   Converts this object to a row. </summary>
		/// <returns>   This object as a string. </returns>
		string ToRow();

        /// <summary>
        /// Converts this object to a row.
        /// </summary>
        ///
        /// <param name="version">  The version. </param>
        ///
        /// <returns>
        /// This object as a string.
        /// </returns>
        //string ToRow(DataCategoryVersion version);
    }
}