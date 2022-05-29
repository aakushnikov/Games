namespace Games.Model
{
	public class RelativeLocation
	{
		public Location Location { get; set; }
		public string Condition { get; set; }
		public bool Checked { get; set; }

		public RelativeLocation(Location location, string condition, bool @checked = false)
		{
			Location = location;
			Condition = condition;
			Checked = @checked;
		}
	}
}
