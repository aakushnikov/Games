namespace Games.Model
{
	public class NPC
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Uri? Wiki { get; set; }
		public Location? Location { get; set; }
		public RelativeLocation[]? Locations { get; set; }
		public string? Notes { get; set; }
		public bool Met { get; set; }

		public NPC(string name, string description, Uri? wiki = null,
			Location? location = null, RelativeLocation[]? locations = null,
			string? notes = null, bool met = false)
		{
			Name = name;
			Description = description;
			Wiki = wiki;
			Location = location;
			Locations = locations;
			Notes = notes;
			Met = met;
		}
	}
}
