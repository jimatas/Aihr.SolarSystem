namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// A specialization of the celestial body type to represent stars.
    /// </summary>
    /// <remarks>
    /// Note that <see cref="SolarSystemObject.DistanceFromPrimary"/> still makes sense on <see cref="Star"/> since this object model could theoretically be used to model any planetary system, 
    /// including those with more than one star, in which case the main star would be the gravitational primary.
    /// </remarks>
    public class Star : SolarSystemObject
    {
        public Star(string name, string picture, double mass, double orbitalPeriod, long distanceFromPrimary)
            : base(name, picture, mass, orbitalPeriod, distanceFromPrimary)
        {
        }
    }
}
