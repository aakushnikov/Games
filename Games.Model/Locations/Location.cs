namespace Games.Model
{
	public class Location
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Region? Region { get; set; }
		public Uri? Wiki { get; set; }
		public Uri? Map { get; set; }
		public string? Notes { get; set; }

		public Location(string name, string description, Region region, Uri? wiki = null, Uri? map = null, string? notes = null)
		{
			Name = name;
			Description = description;
			Wiki = wiki;
			Map = map;
			Notes = notes;
		}
	}
}
