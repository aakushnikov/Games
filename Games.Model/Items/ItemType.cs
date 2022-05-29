namespace Games.Model
{
	public sealed class ItemType
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ItemCategory Category { get; set; }

		public ItemType(string name, string description, ItemCategory category)
		{
			Name = name;
			Description = description;
			Category = category;
		}
	}
}
