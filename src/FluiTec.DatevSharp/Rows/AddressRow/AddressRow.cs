using FluiTec.DatevSharp.Helpers;

namespace FluiTec.DatevSharp.Rows.AddressRow
{
	/// <summary>   The address row. </summary>
	public class AddressRow : Interfaces.IDatevRow
	{
		#region Methods

		/// <summary>   Converts this object to a row. </summary>
		/// <returns>   This object as a string. </returns>
		public string ToRow()
		{
			return
				$"{AccountNumber.ToDatev()};{Name_Enterprise.ToDatev()};{NameExtension1.ToDatev()};{Name_Person.ToDatev()};{FirstName_Person.ToDatev()};{Name.ToDatev()};{AddressType.ToString().ToDatev()};" +
				$"{ShortName.ToDatev()};\"\";\"\";{Salutation.ToDatev()};\"\";\"\";\"\";{PostalAddressType.ToDatev()};{Street.ToDatev()};{PostBox.ToDatev()};{ZipCode.ToDatev()};{City.ToDatev()};\"\";{TransportAddition.ToDatev()};{AddressAddition.ToDatev()};\"\";\"\";\"\";1;;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"1\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";;;;;;;;;;;;;;;;;;;;;;;;;;\"\";\"\";;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;;;;;;;;;;";
		}

		#endregion

		#region Properties

		/// <summary>   Gets or sets the account number. </summary>
		/// <value> The account number. </value>
		public int AccountNumber { get; set; }

		/// <summary>   Gets or sets the salutation. </summary>
		/// <value> The salutation. </value>
		/// <remarks>
		///     MaxLength=30
		/// </remarks>
		public string Salutation { get; set; }

		/// <summary>   Gets or sets the name. </summary>
		/// <value> The name. </value>
		/// <remarks>
		///     MaxLength=50
		/// </remarks>
		public string Name { get; set; }

		/// <summary>   Gets or sets the name of the short. </summary>
		/// <value> The name of the short. </value>
		/// <remarks>
		///     MaxLength=15
		/// </remarks>
		public string ShortName { get; set; }

		/// <summary>   Gets or sets the name enterprise. </summary>
		/// <value> The name enterprise. </value>
		/// <remarks>
		///     MaxLength=50
		/// </remarks>
		public string Name_Enterprise { get; set; }

		/// <summary>   Gets or sets the name person. </summary>
		/// <value> The name person. </value>
		/// <remarks>
		///     MaxLength=30
		/// </remarks>
		public string Name_Person { get; set; }

		/// <summary>   Gets or sets the person's first name. </summary>
		/// <value> The name of the first. </value>
		/// <remarks>
		///     MaxLength=30
		/// </remarks>
		public string FirstName_Person { get; set; }

        /// <summary>   Gets or sets the name extension 1. </summary>
        ///
        /// <value> The name extension 1. </value>
		/// <remarks>
        /// MaxLength=50         
        /// </remarks>
		public string NameExtension1 { get; set; }

        /// <summary>   Gets or sets the name extension 2. </summary>
        ///
        /// <value> The name extension 2. </value>
		/// <remarks>
        /// MaxLength=36       
        /// </remarks>
		public string NameExtension2 { get; set; }

		/// <summary>   Gets or sets the type of the address. </summary>
		/// <value> The type of the address. </value>
		/// <remarks>
		///     MaxLength=1, PossibleValues= 1-3 incl.
		///     1=Undefined
		///     2=Person
		///     3=Enterprise
		/// </remarks>
		public int AddressType { get; set; }

		/// <summary>   Gets or sets the type of the postal address. </summary>
		/// <value> The type of the postal address. </value>
		/// <remarks>
		///     STR, PF, GK
		///     MaxLength=3
		/// </remarks>
		public string PostalAddressType { get; set; }

		/// <summary>   Gets or sets the street. </summary>
		/// <value> The street. </value>
		/// <remarks>
		///     MaxLength=36
		/// </remarks>
		public string Street { get; set; }

		/// <summary>   Gets or sets the post box. </summary>
		/// <value> The post box. </value>
		/// <remarks>
		///     MaxLength=10
		/// </remarks>
		public string PostBox { get; set; }

        /// <summary>   Gets or sets the zip code. </summary>
        ///
        /// <value> The zip code. </value>
		/// <remarks>
        /// MaxLength=10         
        /// </remarks>
		public string ZipCode { get; set; }

        /// <summary>   Gets or sets the city. </summary>
        ///
        /// <value> The city. </value>
		/// <remarks>
        /// MaxLength=30         
        /// </remarks>
		public string City { get; set; }

        /// <summary>   Gets or sets the TransportAddition. </summary>
        ///
        /// <value> The TransportAddition. </value>
        /// <remarks>
        /// MaxLength=50         
        /// </remarks>
        public string TransportAddition { get; set; }

        /// <summary>   Gets or sets the AddressAddition. </summary>
        ///
        /// <value> The TransportAddition. </value>
        /// <remarks>
        /// MaxLength=36         
        /// </remarks>
        public string AddressAddition { get; set; }

		#endregion
	}
}