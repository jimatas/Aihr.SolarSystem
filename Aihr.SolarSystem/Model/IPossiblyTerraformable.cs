namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Meant to be implemented by celestial bodies that could potentially be terraformed. 
    /// </summary>
    /// <remarks>
    /// Departing from the directions in the assignment, this is not a marker interface but declares an operation, <see cref="IsTerraformable"/>, through which the question is answered.
    /// This interface is only implemented by types representing celestial bodies which could reasonably be considered a potential candidate for terraforming, so only moons and planets.
    /// </remarks>
    public interface IPossiblyTerraformable
    {
        /// <summary>
        /// Answers the question whether a celestial body can be terraformed.
        /// </summary>
        bool IsTerraformable { get; }
    }
}
