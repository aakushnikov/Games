using Games.Model;
using Games.Tools.EldenRing;

var elden = new Game("Elden Ring", "Default template", "1.0.4.1");
string path = @"E:\Projects\Games\Data\EldenRing";

Console.WriteLine("Loading...");

EldenRing.LoadItems(Path.Join(path, "er-items.txt"), ref elden);
Console.WriteLine($"Items: {elden.Items?.Length}");

EldenRing.LoadLocations(Path.Join(path, "er-locations.txt"), ref elden);
Console.WriteLine($"Locations: {elden.Locations?.Length}");

EldenRing.LoadBosses(Path.Join(path, "er-bosses.txt"), ref elden);
Console.WriteLine($"Bosses: {elden.Bosses?.Length}");


Console.WriteLine("Saving...");
var filename = Path.Join(path, "elden-ring.json");
elden.ToJson(filename);


Console.WriteLine("Reading...");
var test = Game.FromJson(filename);
Console.WriteLine($"Items: {test.Items?.Length}");
Console.WriteLine($"Locations: {test.Locations?.Length}");
Console.WriteLine($"Bosses: {test.Bosses?.Length}");


Console.ReadKey();
