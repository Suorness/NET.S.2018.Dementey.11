namespace BinarySearch
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class implementing binary search.
    /// </summary>
    public static class BinarySeeker
    {
        /// <summary>
        /// Search for a value.
        /// </summary>
        /// <typeparam name="T"> Parameter Type</typeparam>
        /// <param name="collection">Collection for search.</param>
        /// <param name="key">The value to search.</param>
        /// <param name="comparer">Comparison.</param>
        /// <exception cref="ArgumentException">
        /// An exception is thrown if the parameter <paramref name="array"/> or <paramref name="comparer"/> is null 
        /// or an empty string or string consisting of delimiter characters.
        /// </exception>
        /// <returns>
        /// Number in the collection, in case of failure -1
        /// </returns>
        public static int Search<T>(T[] array, T key, IComparer<T> comparer)
        {
            if (ReferenceEquals(array, null))
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (ReferenceEquals(comparer, null))
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            int left = 0;
            int right = array.Length;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + ((right - left) / 2);

                int resultComparer = comparer.Compare(array[mid], key);
                if (resultComparer == 0)
                {
                    return mid;
                }

                if (resultComparer > 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Search for a value.
        /// </summary>
        /// <typeparam name="T"> Parameter Type</typeparam>
        /// <param name="collection">Collection for search.</param>
        /// <param name="key">The value to search.</param>
        /// <exception cref="ArgumentException">
        /// An exception is thrown if the parameter <paramref name="array"/> or <paramref name="comparer"/> is null 
        /// or an empty string or string consisting of delimiter characters.
        /// </exception>
        /// <returns>
        /// Number in the collection, in case of failure -1
        /// </returns>
        public static int Search<T>(T[] array, T key)
        {
            return Search<T>(array, key, GetDefaultComparer<T>());
        }

        private static IComparer<T> GetDefaultComparer<T>()
        {
            if (typeof(T) == typeof(string))
            {
                return StringComparer.CurrentCulture as IComparer<T>;
            }

            return Comparer<T>.Default;
        }
    }
}