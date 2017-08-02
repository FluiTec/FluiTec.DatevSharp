using System;

namespace FluiTec.Datev.Wpf.Models
{
	/// <summary>	A data Model for the export. </summary>
	public class ExportModel
	{
		/// <summary>	Gets or sets the name. </summary>
		/// <value>	The name. </value>
		public string Name { get; set; }

		/// <summary>	Gets or sets the Date/Time of the exported. </summary>
		/// <value>	The exported. </value>
		public DateTime Exported { get; set; }

		/// <summary>	Gets or sets the Date/Time of from. </summary>
		/// <value>	from. </value>
		public DateTime From { get; set; }

		/// <summary>	Gets or sets the Date/Time of the till. </summary>
		/// <value>	The till. </value>
		public DateTime Till { get; set; }
	}
}