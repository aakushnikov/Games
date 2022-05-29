namespace Games.Model
{
	public class Boss : NPC
	{
		public bool Won { get; set; }

		public Boss(string name, string description, Uri? wiki = null,
			Location? location = null, RelativeLocation[]? locations = null,
			string? notes = null, bool met = false, bool won = false)
			: base(name, description, wiki, location, locations, notes, met)
		{
			Won = won;
		}
	}
}
