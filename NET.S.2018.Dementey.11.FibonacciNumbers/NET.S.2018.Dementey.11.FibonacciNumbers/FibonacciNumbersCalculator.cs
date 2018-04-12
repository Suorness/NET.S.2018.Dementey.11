namespace FibonacciNumbers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Calculates Fibonacci numbers
    /// </summary>
    public class FibonacciNumbersCalculator
    {
        #region private fields
        private const uint FirstNumber = 0;
        private const uint SecondNumber = 1;
        #endregion private fields

        /// <summary>
        /// Generating Fibonacci Numbers
        /// </summary>
        /// <param name="count">Number of numbers in a sequence</param>
        /// <returns>
        /// Sequence.
        /// </returns>
        public static IEnumerable<uint> GetNumbers(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(count)} must be greater than 0");
            }

            uint previous = FirstNumber;
            uint current = SecondNumber;

            for (int i = 0; i < count; i++)
            {
                yield return current = previous + (previous + current);
            }
        }
    }
}
