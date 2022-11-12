namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// Per the assignment, an interface through which planets with natural satellites can be identified.
    /// </summary>
    /// <remarks>
    /// Departing from the directions in the assignment, this is not a marker interface but declares an operation, <see cref="HasMoons"/>, through which the question is answered.
    /// </remarks>
    public interface IPossiblyOrbitedByMoons
    {
        /// <summary>
        /// Answers the question whether the planet has any natural satellites.
        /// </summary>
        bool HasMoons { get; }
    }
}
