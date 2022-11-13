using Aihr.SolarSystem.Model;

namespace Aihr.SolarSystem.Extensions
{
    /// <summary>
    /// Per the assignment, provides extension methods for colonizing celestial bodies, with planets and moons being potential candidates.
    /// </summary>
    public static class ColonizationExtensions
    {
        /// <summary>
        /// Checks to see if a celestial body can be colonized.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns><c>true</c> or <c>false</c> as <paramref name="candidate"/> can either be colonized or not.</returns>
        public static bool CanBeColonized(this SolarSystemObject candidate)
        {
            return (candidate is IPossiblyLifeSustaining possiblyLifeSustaining && possiblyLifeSustaining.CanSustainLife)
                || (candidate is IPossiblyTerraformable possiblyTerraformable && possiblyTerraformable.IsTerraformable);
        }

        /// <summary>
        /// Performs the actual act of colonizing the celestial body.
        /// </summary>
        /// <param name="candidate"></param>
        /// <exception cref="ColonizationNotPossibleException">If <paramref name="candidate"/> is not fit for colonization. 
        /// Determine that first using the <see cref="CanBeColonized(SolarSystemObject)"/> method.</exception>
        public static void Colonize(this SolarSystemObject candidate)
        {
            if (!candidate.CanBeColonized())
            {
                throw new ColonizationNotPossibleException($"Colonization of {candidate.Name} is not possible; it neither sustains life naturally, nor can it be terraformed.");
            }

            // TODO: Colonize
        }
    }
}
