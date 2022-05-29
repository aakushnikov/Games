namespace Games.Model
{
	public sealed class ItemCategory
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public ItemCategory(string name, string description)
		{
			Name = name;
			Description = description;
		}

	}
}
