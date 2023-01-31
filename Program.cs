// See https://aka.ms/new-console-template for more information

using Gorilla_Universe.Existence;
var ourUniverse = new Universe();
Random random = new Random();


foreach(var galaxy in ourUniverse.Galaxies)
{
    Console.WriteLine($"galaxy - {galaxy.ID}");
    var starSystemsWithLife = galaxy.StarSystems.Where(ss => ss.Planets.Any(p => p.HasAtmosphere)).ToList();
    foreach(var starSystem in starSystemsWithLife)
    {
        var numberOfGorillas = 0;
        var numberOfPlanetswithLife = 0;
        var numberOfContinentsWithLife = 0;
        var plantesWithLife = starSystem.Planets.Where(p => p.HasAtmosphere).ToList();
        foreach(var planet in plantesWithLife)
        {
            numberOfPlanetswithLife += 1;
            foreach(var continent in planet.Continents)
            {
                numberOfContinentsWithLife += 1;
                numberOfGorillas += continent.Animals.Where(a => a.Species == "Gorilla").ToList().Count;
            }
        }
        if(numberOfPlanetswithLife >= 2)
        {
            Console.WriteLine($"{starSystem.Name} has {numberOfGorillas} Gorillas across {numberOfContinentsWithLife} Continents on {numberOfPlanetswithLife} planets");
        }
    }

}


