using Aihr.SolarSystem.Model;

namespace Aihr.SolarSystem.Extensions
{
    /// <summary>
    /// Per the assignment, provides extension methods for colonizing candidate planets and moons.
    /// </summary>
    public static class ColonizationExtensions
    {
        /// <summary>
        /// Checks to see if a planet can be colonized.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns><c>true</c> or <c>false</c> as <paramref name="candidate"/> can either be colonized or not.</returns>
        public static bool CanBeColonized(this Planet candidate)
        {
            return (candidate is IPossiblyLifeSustaining possiblyLifeSustaining && possiblyLifeSustaining.CanSustainLife)
                || (candidate is IPossiblyTerraformable possiblyTerraformable && possiblyTerraformable.IsTerraformable);
        }

        /// <summary>
        /// Performs the actual act of colonizing a planet.
        /// </summary>
        /// <param name="candidate"></param>
        /// <exception cref="ColonizationNotPossibleException">If <paramref name="candidate"/> is not fit for colonization. 
        /// Determine that first using <see cref="CanBeColonized(Planet)"/>.</exception>
        public static void Colonize(this Planet candidate)
        {
            if (!candidate.CanBeColonized())
            {
                ThrowColonizationNotPossibleExceptionWithDefaultMessage(candidate);
            }

            // TODO: Colonize
        }

        /// <summary>
        /// Checks to see if a moon can be colonized.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns><c>true</c> or <c>false</c> as <paramref name="candidate"/> can either be colonized or not.</returns>
        public static bool CanBeColonized(this Moon candidate)
        {
            return (candidate is IPossiblyLifeSustaining possiblyLifeSustaining && possiblyLifeSustaining.CanSustainLife)
                || (candidate is IPossiblyTerraformable possiblyTerraformable && possiblyTerraformable.IsTerraformable);
        }

        /// <summary>
        /// Performs the actual act of colonizing a moon.
        /// </summary>
        /// <param name="candidate"></param>
        /// <exception cref="ColonizationNotPossibleException">If <paramref name="candidate"/> is not fit for colonization. 
        /// Determine that first using <see cref="CanBeColonized(Moon)"/>.</exception>
        public static void Colonize(this Moon candidate)
        {
            if (!candidate.CanBeColonized())
            {
                ThrowColonizationNotPossibleExceptionWithDefaultMessage(candidate);
            }

            // TODO: Colonize
        }

        private static string ThrowColonizationNotPossibleExceptionWithDefaultMessage(SolarSystemObject candidate)
            => throw new ColonizationNotPossibleException($"Colonization of {candidate.Name} is not possible; it neither sustains life naturally, nor can it be terraformed.");
    }
}
