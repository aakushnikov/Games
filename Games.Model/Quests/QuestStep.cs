namespace Games.Model
{
	public sealed class QuestStep
	{
		public string Description { get; set; }
		public bool IsDone { get; set; }

		public QuestStep(string description, bool isDone = false)
		{
			Description = description;
			IsDone = isDone;
		}
	}
}
