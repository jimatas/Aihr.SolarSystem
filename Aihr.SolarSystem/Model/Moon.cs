namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Further specialization of the celestial body type for representing natural satellites of a planet.
    /// </summary>
    public class Moon : SolarSystemObject, IPossiblyLifeSustaining, IPossiblyTerraformable
    {
        public Moon(string name, string picture, double mass, double orbitalPeriod, long distanceFromPrimary, bool canSustainLife, bool isTerraformable)
            : base(name, picture, mass, orbitalPeriod, distanceFromPrimary)
        {
            CanSustainLife = canSustainLife;
            IsTerraformable = isTerraformable;
        }

        /// <summary>
        /// The planet the moon orbits, also known as its gravitational primary.
        /// The orbital period of the moon will be in relation to this celestial body.
        /// </summary>
        public Planet Planet { get; internal set; } = default!;

        /// <inheritdoc/>
        public bool CanSustainLife { get; }

        /// <inheritdoc/>
        public bool IsTerraformable { get; }
    }
}
