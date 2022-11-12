namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// This type represents a planetary system and serves as a container for all the celestial bodies within it.
    /// It's named after our own Solar System but could represent any such system.
    /// </summary>
    public class SolarSystem
    {
        private readonly List<SolarSystemObject> celestialBodies;

        public SolarSystem(IEnumerable<SolarSystemObject> celestialBodies)
        {
            this.celestialBodies = new List<SolarSystemObject>(celestialBodies);
        }

        /// <summary>
        /// A read-only, flattened view of all celestial bodies in the planetary system. 
        /// This includes the gravitational primary as well as the individual natural satellites of the various planets.
        /// </summary>
        /// <see cref="PrimaryBody"/>
        public IReadOnlyList<SolarSystemObject> CelestialBodies => celestialBodies.AsReadOnly();

        /// <summary>
        /// The gravitational primary of the planetary system, which for our Solar System is the Sun.
        /// </summary>
        public Star PrimaryBody => celestialBodies.OfType<Star>().First(); // First() instead of Single() because this model could theoretically be used to represent other planetary systems, potentially with multiple stars.
    }
}
