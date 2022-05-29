using System.Text;
using System.Text.Json;

namespace Games.Model
{
	public class Game : ICloneable
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Version { get; set; }
		public DateTime Date { get; set; }
		public Uri? Logo { get; set; }
		public Uri? Wiki { get; set; }
		public string? Notes { get; set; }
		public Quest[]? Quests { get; set; }
		public Location[]? Locations { get; set; }
		public Boss[]? Bosses { get; set; }
		public NPC[]? NPCs { get; set; }
		public Item[]? Items { get; set; }

		public Game(string name, string description, string version, Uri? logo = null, Uri? wiki = null, string? notes = null,
			Quest[]? quests = null, Location[]? locations = null, Boss[]? bosses = null, NPC[]? npcs = null, Item[]? items = null)
		{
			Name = name;
			Description = description;
			Version = version;
			Date = DateTime.Now;
			Logo = logo;
			Wiki = wiki;
			Notes = notes;
			Quests = quests;
			Locations = locations;
			Bosses = bosses;
			NPCs = npcs;
			Items = items;
		}

		public void ToJson(string path)
		{
			string json = JsonSerializer.Serialize<Game>(this);
			using (var stream = File.Create(path))
				stream.Write(Encoding.UTF8.GetBytes(json));
		}

		public static Game FromJson(string path)
		{
			using (var stream = File.OpenRead(path))
			{
				var game = JsonSerializer.Deserialize<Game>(stream);

				if (game != null)
					return game;
				else
					throw new Exception($"Cannot read JSON for Game object from file: {path}");
			}
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}