namespace BinarySearch
{
    // TODO: comments and tests
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public static class BinarySeeker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static int Search<T>(T[] array, T value, IComparer<T> comparer)
        {
            if (ReferenceEquals(array, null))
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (ReferenceEquals(comparer, null))
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            int startIndex = 0;
            int endIndex = array.Length - 1;

            while (startIndex <= endIndex)
            {
                int center = startIndex + ((endIndex - startIndex) / 2);

                int resultComparer = comparer.Compare(array[center], value);
                if (resultComparer == 0)
                {
                    return resultComparer;
                }

                if (resultComparer < 0)
                {
                    startIndex = center + 1;
                }
                else
                {
                    endIndex = center - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Search<T>(T[] array, T value)
        {
            return Search<T>(array, value, GetDefaultComparer<T>());
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