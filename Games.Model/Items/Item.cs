namespace Games.Model
{
	public class Item
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ItemType Type { get; set; }
		public Uri? Wiki { get; set; }
		public Location? Location { get; set; }
		public RelativeLocation[]? Locations { get; set; }
		public string? Notes { get; set; }
		public bool Obtained { get; set; }

		public Item(string name, string description, ItemType type, Uri? wiki = null,
			Location? location = null, RelativeLocation[]? locations = null,
			string? notes = null, bool obtained = false)
		{
			Name = name;
			Description = description;
			Type = type;
			Wiki = wiki;
			Location = location;
			Locations = locations;
			Notes = notes;
			Obtained = obtained;
		}
	}
}
