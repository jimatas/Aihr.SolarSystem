using Aihr.SolarSystem.Bootstrap;
using Aihr.SolarSystem.Extensions;
using Aihr.SolarSystem.Model;

SolarSystem solarSystem = SolarSystemInitializer.Initialize();

// The primary celestial body of our planetary system is the Sun.
var sun = solarSystem.PrimaryBody;

Console.WriteLine("The gravitational primary of the Solar System is the {0}.", sun.Name);

// Iterate through the planets after ordering them by increasing orbital period.
// The orbit of a planet in our Solar System is around the Sun, whereas the orbit of a moon is around its planet and the orbit of the Sun is around the center of the galaxy.
foreach (var planet in solarSystem.CelestialBodies.OfType<Planet>().OrderBy(p => p.OrbitalPeriod))
{
    Console.WriteLine("The next planet out from the {0} is {1}.", sun.Name, planet.Name);

    Console.WriteLine("- It is ~{0:N} kilometers away from the {1} and has an orbital period of ~{2:N} days.",
        planet.DistanceFromPrimary, sun.Name, planet.OrbitalPeriod);

    if (planet.CanBeColonized())
    {
        Console.WriteLine("- It can be colonized.");

        planet.Colonize();
    }

    if (planet.HasMoons)
    {
        Console.Write("- It has moons, ");

        ICollection<Moon> colonizableMoons = new List<Moon>();

        // Iterate through the planet's moons, having ordered them by increasing orbital period first.
        foreach (var moon in planet.Moons.OrderBy(m => m.OrbitalPeriod))
        {
            if (moon.CanBeColonized())
            {
                colonizableMoons.Add(moon);
                moon.Colonize();
            }
        }

        if (colonizableMoons.Any())
        {
            Console.WriteLine("of which at least {0} can be colonized: {1}.", colonizableMoons.Count, string.Join(", ", colonizableMoons.Select(m => m.Name)));
        }
        else
        {
            Console.WriteLine("none of which can be colonized.");
        }
    }
}
