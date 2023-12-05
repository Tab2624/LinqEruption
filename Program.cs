List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? firstChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
System.Console.WriteLine(firstChile.ToString());

// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstHawaii = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if(firstHawaii == null)
{
    System.Console.WriteLine("No Hawaiian Is Eruption found.");
}
else {
    System.Console.WriteLine(firstHawaii.ToString());
}

// Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? firstGreenLand = eruptions.FirstOrDefault(e => e.Location == "GreenLand");
if(firstGreenLand == null)
{
    System.Console.WriteLine("No Greenland Eruption found.");
}
else {
    System.Console.WriteLine(firstGreenLand.ToString());
}

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? newZel = eruptions.Where(y => y.Year > 1900).FirstOrDefault(e => e.Location == "New Zealand");
System.Console.WriteLine(newZel.ToString());

// Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> EruptionsOver2000M = eruptions.Where(m => m.ElevationInMeters > 2000).ToList();
PrintEach(EruptionsOver2000M);

// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> StartWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
PrintEach(StartWithL);
System.Console.WriteLine($"Count is: {StartWithL.Count()}");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElev = eruptions.Max( e => e.ElevationInMeters);
System.Console.WriteLine($"Highest Elevation is: {highestElev}");

// Use the highest elevation variable to find and print the name of the Volcano with that elevation.
Eruption? volcWithHighestElev = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElev);
System.Console.WriteLine($"The Volcano with the highest elevation is: {volcWithHighestElev.ToString()}");

// Print all Volcano names alphabetically.
List<Eruption> AlphaSorted = eruptions.OrderBy(e => e.Volcano).ToList();
PrintEach(AlphaSorted);

// Print the sum of all the elevations of the volcanoes combined.
int SumOfElev = eruptions.Sum(e => e.ElevationInMeters);
System.Console.WriteLine($"The Sum of all Elevations is: {SumOfElev}");

// Print whether any volcanoes erupted in the year 2000
bool EruptedIn2000 = eruptions.Any(e => e.Year == 2000);
System.Console.WriteLine($"Did any volcanoes erupt in 2000?:{EruptedIn2000}");

// Find all stratovolcanoes and print just the first three (Hint: look up Take)
List<Eruption> ThreeStratoVolc = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
PrintEach(ThreeStratoVolc);

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> Before1000CE = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
PrintEach(Before1000CE);
static void PrintEachName(IEnumerable<Eruption> items)
{
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.Volcano.ToString());
    }
}
PrintEachName(Before1000CE);