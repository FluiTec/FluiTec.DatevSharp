namespace FluiTec.Datev.Wpf.Services
{
	public interface ISerializer
	{
		void Serialize<T>(T entity, string file);
		T Deserialize<T>(string file);
	}
}