namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Meant to be implemented by celestial bodies that could potentially sustain life. 
    /// </summary>
    /// <remarks>
    /// Departing from the directions in the assignment, this is not a marker interface but declares an operation, <see cref="CanSustainLife"/>, through which the question is answered.
    /// This interface is only implemented by types representing celestial bodies which could reasonably be expected to sustain life naturally, so only moons and planets.
    /// </remarks>
    public interface IPossiblyLifeSustaining
    {
        /// <summary>
        /// Answers the question whether a celestial body can naturally sustain life.
        /// </summary>
        bool CanSustainLife { get; }
    }
}
