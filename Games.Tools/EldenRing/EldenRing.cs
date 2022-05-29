using Games.Model;

namespace Games.Tools.EldenRing
{
	internal static class EldenRing
	{
		internal static void LoadItems(string path, ref Game game)
		{
			IList<Item> items = new List<Item>();

			using (StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8))
			{
				string? line;
				ItemCategory? category = null;
				ItemType? type = null;

				// Skip first
				reader.ReadLine();

				while ((line = reader.ReadLine()) != null)
				{
					if (string.IsNullOrEmpty(line))
					{
						category = null;
						type = null;
						continue;
					}
					if (line.First() == 9660)
					{
						var index = line.IndexOf('(');
						var name = line.Substring(1, index - 1).Trim();
						if (line.IndexOf("Expand All Collapse All") != -1)
							category = new ItemCategory(name, string.Empty);
						else
						{
							if (category != null)
								type = new ItemType(name, string.Empty, category);
							else
								throw new Exception($"Incorrect file format. There was no category created. Line: {line}");
						}
					}
					else
					{
						var values = line.Split('\t');
						if (values.Length != 3)
							throw new Exception($"Incorrect file format. The must be 3 tab separated values. Line: {line}");
						if (values.First().Trim().ToLower() == "obtained") continue;
						if (type == null)
							throw new Exception($"Incorrect file format. The was no type created. Line: {line}");
						else
						{
							var item = new Item(values[1], values[2], type);
							items.Add(item);
						}
					}
				}
			}

			game.Items = items.ToArray();
		}

		internal static void LoadLocations(string path, ref Game game)
		{
			IList<Location> locations = new List<Location>();

			using (StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8))
			{
				string? line;
				Region? region = null;

				// Skip first
				reader.ReadLine();

				while ((line = reader.ReadLine()) != null)
				{
					if (string.IsNullOrEmpty(line))
					{
						region = null;
						continue;
					}

					if (line.Trim() == string.Empty)
						continue;

					if (line.ToUpper() == line)
					{
						var name = string.Concat(line.ToUpper().First(), line.Substring(1).ToLower());
						region = new Region(name);
					}
					else
					{
						if (region == null)
							throw new Exception($"There was no region created. Line: {line}");

						var name = line;
						if (name.ToUpper() == line)
							throw new Exception($"Something went wrong. Line: {line}");

						var location = new Location(name, string.Empty, region);
						locations.Add(location);
					}
				}
			}

			game.Locations = locations.ToArray();
		}


		internal static void LoadBosses(string path, ref Game game)
		{
			IList<Boss> bosses = new List<Boss>();

			using (StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8))
			{
				string? line;

				// Skip first
				reader.ReadLine();

				while ((line = reader.ReadLine()) != null)
				{
					if (string.IsNullOrEmpty(line))
						continue;

					if (line.Trim() == string.Empty)
						continue;

					if (line.Contains("BOSSES IN"))
					{
						reader.ReadLine();
						continue;
					}

					var name = line;
					if (name.ToUpper() == line)
						throw new Exception($"Something went wrong. Line: {line}");

					var boss = new Boss(name, string.Empty);
					bosses.Add(boss);
				}
			}

			game.Bosses = bosses.ToArray();
		}
	}
}