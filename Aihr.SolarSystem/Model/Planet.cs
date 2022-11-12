namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Specialization of the celestial body type for representing planets.
    /// The type of planet (terrestrial, gas giant etc.) is specified through a property of this class rather than through a further specialization.
    /// </summary>
    public class Planet : SolarSystemObject, IPossiblyOrbitedByMoons, IPossiblyLifeSustaining, IPossiblyTerraformable
    {
        private readonly List<Moon> moons = new();

        public Planet(string name, string picture, double mass, double orbitalPeriod, long distanceFromPrimary, PlanetType type, bool canSustainLife, bool isTerraformable, IEnumerable<Moon>? moons = default)
            : base(name, picture, mass, orbitalPeriod, distanceFromPrimary)
        {
            Type = type;
            CanSustainLife = canSustainLife;
            IsTerraformable = isTerraformable;
            InitializeMoons(moons);
        }

        private void InitializeMoons(IEnumerable<Moon>? moons)
        {
            if (moons is not null)
            {
                foreach (var moon in moons)
                {
                    AddMoon(moon);
                }
            }
        }

        /// <summary>
        /// Denotes the type of the planet.
        /// </summary>
        public PlanetType Type { get; }

        /// <inheritdoc/>
        public bool HasMoons => moons.Any();

        /// <summary>
        /// A read-only view of the natural satellites, if any, that orbit the planet.
        /// </summary>
        /// <seealso cref="HasMoons"/>
        public IReadOnlyList<Moon> Moons => moons.AsReadOnly();

        /// <summary>
        /// Associates a natural sattelite with its planet.
        /// </summary>
        /// <param name="moon"></param>
        public void AddMoon(Moon moon)
        {
            moons.Add(moon);
            moon.Planet = this;
        }

        /// <inheritdoc/>
        public bool CanSustainLife { get; }

        /// <inheritdoc/>
        public bool IsTerraformable { get; }
    }
}
