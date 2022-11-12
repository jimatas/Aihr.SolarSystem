namespace Aihr.SolarSystem.Extensions
{
    /// <summary>
    /// Provides some very hacky extension methods on the generic collection type for the sole purpose of convenience.
    /// </summary>
    /// <remarks>
    /// Deliberately declared with internal visibility.
    /// </remarks>
    internal static class CollectionExtensions
    {
        /// <summary>
        /// Adds a new item to the collection and immediately returns that item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static T AddAndReturn<T>(this ICollection<T> collection, T item)
        {
            collection.Add(item);
            return item;
        }

        /// <summary>
        /// Creates a <see cref="List{T}"/> containing all the items in the source collection and clears the source collection after.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static List<T> ToListAndClear<T>(this ICollection<T> collection)
        {
            var list = collection.ToList();
            collection.Clear();
            return list;
        }
    }
}
