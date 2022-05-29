namespace Games.Model
{
	public class Quest
	{
		public QuestTypes Type { get; set; }
		public NPC? QuestGiver { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public QuestStep[] Steps { get; set; }

		public Quest(QuestTypes type, NPC? questGiver, string name, string description, QuestStep[] steps)
		{
			Type = type;
			QuestGiver = questGiver;
			Name = name;
			Description = description;
			Steps = steps;
		}
	}
}
