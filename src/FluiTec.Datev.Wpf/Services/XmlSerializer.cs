using System.IO;

namespace FluiTec.Datev.Wpf.Services
{
	public class XmlSerializer : ISerializer
	{
		public void Serialize<T>(T entity, string file)
		{
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			using (var sw = new StreamWriter(file))
			{
				serializer.Serialize(sw, entity);
			}
		}

		public T Deserialize<T>(string file)
		{
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			using (var sr = new StreamReader(file))
			{
				return (T) serializer.Deserialize(sr);
			}
		}
	}
}