namespace Aihr.SolarSystem.Model
{
    /// <summary>
    /// The exception thrown to indidicate a celestial body that is unfit for colonization was attempted to be colonized.
    /// </summary>
    public class ColonizationNotPossibleException : Exception
    {
        public ColonizationNotPossibleException() { }
        public ColonizationNotPossibleException(string? message) : base(message) { }
    }
}
