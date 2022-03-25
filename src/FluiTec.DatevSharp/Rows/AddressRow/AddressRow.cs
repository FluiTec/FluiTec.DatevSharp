using FluiTec.DatevSharp.Attributes;
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
				$"{AccountNumber.ToDatev()};{Name_Enterprise.ToDatev()};{Name_Enterprise_Extension.ToDatev()};{Name_Person.ToDatev()};{FirstName_Person.ToDatev()};{Name.ToDatev()};{AddressType.ToString().ToDatev()};" +
				$"{ShortName.ToDatev()};\"\";\"\";{Salutation.ToDatev()};\"\";\"\";\"\";{PostalAddressType.ToDatev()};{Street.ToDatev()};{PostBox.ToDatev()};{ZipCode.ToDatev()};{City.ToDatev()};\"\";{TransportAddition.ToDatev()};{AddressAddition.ToDatev()};\"\";\"\";\"\";{MarkerCorrespondenceAddress.ToDatev()};;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";{MarkerMainBankingAccount1.ToDatev()};;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";;;;;;;;;;;;;;;;;;;;;;;;;;\"\";\"\";;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;\"\";;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\";;;;;;;;;;;;";
		}

		#endregion

		#region Properties

		/// <summary>   Gets or sets the account number. </summary>
		/// <value> The account number. </value>
        [DatevField(0, 1)]
		public int AccountNumber { get; set; }

        /// <summary>   Gets or sets the name enterprise. </summary>
        /// <value> The name enterprise. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(1, 1)]
        public string Name_Enterprise { get; set; }

        /// <summary>   Gets or sets the name extension 1. </summary>
        ///
        /// <value> The name extension 1. </value>
        /// <remarks>
        /// MaxLength=50         
        /// </remarks>
        [DatevField(2, 1)]
        public string Name_Enterprise_Extension { get; set; }

        /// <summary>   Gets or sets the name person. </summary>
        /// <value> The name person. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(3, 1)]
        public string Name_Person { get; set; }

        /// <summary>   Gets or sets the person's first name. </summary>
        /// <value> The name of the first. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(4, 1)]
        public string FirstName_Person { get; set; }

        /// <summary>   Gets or sets the name. </summary>
        /// <value> The name. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(5, 1)]
        public string Name { get; set; }

        /// <summary>   Gets or sets the type of the address. </summary>
        /// <value> The type of the address. </value>
        /// <remarks>
        ///     MaxLength=1, PossibleValues= 0-2 incl.
        /// </remarks>
        [DatevField(6, 1)]
        public AddressType AddressType { get; set; }

        /// <summary>   Gets or sets the name of the short. </summary>
        /// <value> The name of the short. </value>
        /// <remarks>
        ///     MaxLength=15
        /// </remarks>
        [DatevField(7, 1)]
        public string ShortName { get; set; }

        /// <summary>   Gets or sets the salutation. </summary>
        /// <value> The salutation. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(10,1)]
		public string Salutation { get; set; }

        /// <summary>   Gets or sets the type of the postal address. </summary>
        /// <value> The type of the postal address. </value>
        /// <remarks>
        ///     STR, PF, GK
        ///     MaxLength=3
        /// </remarks>
        [DatevField(14, 1)]
        public string PostalAddressType { get; set; }

        /// <summary>   Gets or sets the street. </summary>
        /// <value> The street. </value>
        /// <remarks>
        ///     MaxLength=36
        /// </remarks>
        [DatevField(15, 1)]
        public string Street { get; set; }

        /// <summary>   Gets or sets the post box. </summary>
        /// <value> The post box. </value>
        /// <remarks>
        ///     MaxLength=10
        /// </remarks>
        [DatevField(16, 1)]
        public string PostBox { get; set; }

        /// <summary>   Gets or sets the zip code. </summary>
        ///
        /// <value> The zip code. </value>
        /// <remarks>
        /// MaxLength=10         
        /// </remarks>
        [DatevField(17, 1)]
        public string ZipCode { get; set; }

        /// <summary>   Gets or sets the city. </summary>
        ///
        /// <value> The city. </value>
        /// <remarks>
        /// MaxLength=30         
        /// </remarks>
        [DatevField(18, 1)]
        public string City { get; set; }
        
        /// <summary>   Gets or sets the TransportAddition. </summary>
        ///
        /// <value> The TransportAddition. </value>
        /// <remarks>
        /// MaxLength=50         
        /// </remarks>
        [DatevField(20,1)]
        public string TransportAddition { get; set; }

		/// <summary>   Gets or sets the AddressAddition. </summary>
		///
		/// <value> The TransportAddition. </value>
		/// <remarks>
		/// MaxLength=36         
		/// </remarks>
		[DatevField(21, 1)]
        public string AddressAddition { get; set; }

        /// <summary>
        /// Gets the marker correspondence address.
        /// </summary>
        ///
        /// <value>
        /// The marker correspondence address.
        /// </value>
        /// <remarks>
        /// MaxLength=1
        /// Only valid value = 1
        /// </remarks>
        [DatevField(25,1)]
        public int MarkerCorrespondenceAddress => 1;

        /// <summary>
        /// Gets the marker main banking account 1.
        /// </summary>
        ///
        /// <value>
        /// The marker main banking account 1.
        /// </value>
        [DatevField(48,1)]
        public string MarkerMainBankingAccount1 => "1";

        #endregion
    }
}