using Games.Model;

namespace Games.Services
{
	public sealed class MainService
	{
		private ICollection<Game> _templates;

		public MainService()
		{
			_templates = new List<Game>();
		}

		private void LoadTemplates()
		{
			// TODO getting the path from Config. Get example and nuget from TPC project
			// TODO reading and deserialising Game from each .json file by path
		}
	}
}