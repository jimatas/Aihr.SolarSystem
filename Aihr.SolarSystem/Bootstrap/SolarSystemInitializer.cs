using Aihr.SolarSystem.Extensions;
using Aihr.SolarSystem.Model;

namespace Aihr.SolarSystem.Bootstrap
{
    /// <summary>
    /// Application bootstrapping code.
    /// </summary>
    /// <remarks>
    /// Deliberately declared with internal visibility.
    /// </remarks>
    internal static class SolarSystemInitializer
    {
        /// <summary>
        /// Returns a populated solar system model using data that was obtained from both Wikipedia and NASA.
        /// </summary>
        /// <returns>A reference to a fully initialized <see cref="Model.SolarSystem"/> instance.</returns>
        public static Model.SolarSystem Initialize()
        {
            ICollection<Moon> moons = new List<Moon>();

            IList<SolarSystemObject> celestialBodies = new SolarSystemObject[]
            {
                new Star(
                    name: "Sun",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/stars/sun.jpg",
                    mass: 1.989e30,
                    orbitalPeriod: (double)226_000_000d * 365,
                    distanceFromPrimary: 0),

                new Planet(
                    name: "Mercury",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/mercury.jpg",
                    mass: 3.285e23,
                    orbitalPeriod: 88,
                    distanceFromPrimary: 58_000_000,
                    PlanetType.Terrestrial,
                    canSustainLife: false,
                    isTerraformable: true),

                new Planet(
                    name: "Venus",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/venus.jpg",
                    mass: 4.867e24,
                    orbitalPeriod: 225,
                    distanceFromPrimary: 108_200_000,
                    PlanetType.Terrestrial,
                    canSustainLife: false,
                    isTerraformable: true),

                moons.AddAndReturn(new Moon(
                    name: "Luna",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/moon.jpg",
                    mass: 7.342e22,
                    orbitalPeriod: 27,
                    distanceFromPrimary: 398_266,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Earth",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/earth.jpg",
                    mass: 5.972e24,
                    orbitalPeriod: 365,
                    distanceFromPrimary: 149_600_000,
                    PlanetType.Terrestrial,
                    canSustainLife: true,
                    isTerraformable: false,
                    moons.ToListAndClear()),

                moons.AddAndReturn(new Moon(
                    name: "Phobos",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/phobos.jpg",
                    mass: 1.0659e16,
                    orbitalPeriod: 0.31891023,
                    distanceFromPrimary: 6_000,
                    canSustainLife: false,
                    isTerraformable: false)),

                moons.AddAndReturn(new Moon(
                    name: "Deimos",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/deimos.jpg",
                    mass: 1.4762e15,
                    orbitalPeriod: 1.263,
                    distanceFromPrimary: 23_460,
                    canSustainLife: false,
                    isTerraformable: false)),

                new Planet(
                    name: "Mars",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/mars.jpg",
                    mass: 6.4171e23,
                    orbitalPeriod: 779.94,
                    distanceFromPrimary: 228_000_000,
                    PlanetType.Terrestrial,
                    canSustainLife: false,
                    isTerraformable: true,
                    moons.ToListAndClear()),

                // I'm doing 4 of the Jovian moons because they were Eclipse IDE code names back in the day.
                // For all other planets, I'm just going to do one or two at most.

                moons.AddAndReturn(new Moon(
                    name: "Io",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/io.jpg",
                    mass: 8.931938e22,
                    orbitalPeriod: 1.769137786,
                    distanceFromPrimary: 350_000,
                    canSustainLife: false,
                    isTerraformable: true)),

                moons.AddAndReturn(new Moon(
                    name: "Europa",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/europa.jpg",
                    mass: 4.799844e22,
                    orbitalPeriod: 3.551181,
                    distanceFromPrimary: 671_000,
                    canSustainLife: false,
                    isTerraformable: true)),

                moons.AddAndReturn(new Moon(
                    name: "Ganymede",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/ganymede.jpg",
                    mass: 1.4819e23,
                    orbitalPeriod: 7.15455296,
                    distanceFromPrimary: 1_070_000,
                    canSustainLife: false,
                    isTerraformable: true)),

                moons.AddAndReturn(new Moon(
                    name: "Callisto",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/callisto.jpg",
                    mass: 1.075938e23,
                    orbitalPeriod: 16.6890184,
                    distanceFromPrimary: 1_883_000,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Jupiter",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/jupiter.jpg",
                    mass: 1.898e27,
                    orbitalPeriod: (double)12 * 365,
                    distanceFromPrimary: 778_500_000,
                    PlanetType.GasGiant,
                    canSustainLife: false,
                    isTerraformable: false,
                    moons.ToListAndClear()),

                moons.AddAndReturn(new Moon(
                    name: "Titan",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/titan.jpg",
                    mass: 1.3452e23,
                    orbitalPeriod: 15.945,
                    distanceFromPrimary: 1_200_000,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Saturn",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/saturn.jpg",
                    mass: 5.683e26,
                    orbitalPeriod: (double)29 * 365,
                    distanceFromPrimary: 1_434_000_000,
                    PlanetType.GasGiant,
                    canSustainLife: false,
                    isTerraformable: false,
                    moons.ToListAndClear()),

                moons.AddAndReturn(new Moon(
                    name: "Titania",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/titania.jpg",
                    mass: 3.400e21,
                    orbitalPeriod: 8.706234,
                    distanceFromPrimary: 435_840,
                    canSustainLife: false,
                    isTerraformable: true)),

                moons.AddAndReturn(new Moon(
                    name: "Oberon",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/oberon.jpg",
                    mass: 3.076e21,
                    orbitalPeriod: 13.463234,
                    distanceFromPrimary: 582_600,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Uranos",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/uranus.jpg",
                    mass: 8.6810e25,
                    orbitalPeriod: (double)84 * 365,
                    distanceFromPrimary: 2_942_700_000,
                    PlanetType.GasGiant,
                    canSustainLife: false,
                    isTerraformable: false,
                    moons.ToListAndClear()),

                moons.AddAndReturn(new Moon(
                    name: "Triton",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/triton.jpg",
                    mass: 2.1390e22,
                    orbitalPeriod: 5.876854,
                    distanceFromPrimary: 354_800,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Neptune",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/planets/neptune.jpg",
                    mass: 1.02413e26,
                    orbitalPeriod: 164.8 * 365,
                    distanceFromPrimary: 4_473_800_000,
                    PlanetType.IceGiant,
                    canSustainLife: false,
                    isTerraformable: false,
                    moons.ToListAndClear()),

                new Planet(
                    name: "Ceres",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/asteroids_etc/1_ceres.jpg",
                    mass: 9.3835e20,
                    orbitalPeriod: 4.60 * 365,
                    distanceFromPrimary: 413_000_000,
                    PlanetType.DwarfPlanet,
                    canSustainLife: false,
                    isTerraformable: true),

                moons.AddAndReturn(new Moon(
                    name: "Charon",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/moons/charon.jpg",
                    mass: 1.586e21,
                    orbitalPeriod: 6.3872304,
                    distanceFromPrimary: 19_640,
                    canSustainLife: false,
                    isTerraformable: true)),

                new Planet(
                    name: "Pluto",
                    picture: "https://eyes.nasa.gov/apps/orrery/photos/asteroids_etc/134340_pluto.jpg",
                    mass: 1.303e22,
                    orbitalPeriod: 247.94 * 365,
                    distanceFromPrimary: 5_900_000_000,
                    PlanetType.Terrestrial,
                    canSustainLife: false,
                    isTerraformable: true,
                    moons.ToListAndClear())
            };

            return new(celestialBodies);
        }
    }
}
