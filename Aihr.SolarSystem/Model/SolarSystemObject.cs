namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Defines the root of the type hierarchy used to represent celestial bodies within a planetary system.
    /// </summary>
    public abstract class SolarSystemObject
    {
        protected SolarSystemObject(string name, string picture, double mass, double orbitalPeriod, long distanceFromPrimary)
        {
            Name = name;
            Picture = picture;
            Mass = mass;
            OrbitalPeriod = orbitalPeriod;
            DistanceFromPrimary = distanceFromPrimary;
        }

        /// <summary>
        /// The name of the celestial body.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// A reference, such as a URL, to a picture of the celestial body.
        /// </summary>
        public string Picture { get; }

        /// <summary>
        /// The mass of the celestial body in kilograms. 
        /// Note: May be expressed in scientific notation.
        /// </summary>
        public double Mass { get; }

        /// <summary>
        /// The orbital period in days.
        /// Typed as a double precision float to account for fractions of a day or very large orbits, such as the Sun around the center of the Galaxy, where a <see cref="TimeSpan"/> would overflow.
        /// </summary>
        public double OrbitalPeriod { get; }

        /// <summary>
        /// The distance in kilometers to the gravitational primary.
        /// For moons the primary is the planet they orbit.
        /// For planets the primary is the main star in their planetary system; e.g., the Sun in the Solar System.
        /// </summary>
        public long DistanceFromPrimary { get; }
    }
}
