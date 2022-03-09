namespace FluiTec.DatevSharp
{
	public class DataCategory
	{
		/// <summary>   Gets or sets the number.  </summary>
		///
		/// <value> The number. </value>
		public int Number { get; }

		/// <summary>   Gets or sets the name. </summary>
		///
		/// <value> The name. </value>
		public string Name { get; }

		/// <summary>   Gets or sets the version. </summary>
		///
		/// <value> The version. </value>
		public int Version { get; }

		/// <summary>   Constructor. </summary>
		///
		/// <param name="number">   The number. </param>
		/// <param name="name">     The name. </param>
		/// <param name="version">  The version. </param>
		internal DataCategory(int number, string name, int version)
		{
			Number = number;
			Name = name;
			Version = version;
		}
	}
}