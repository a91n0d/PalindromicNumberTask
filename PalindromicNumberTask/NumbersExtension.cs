using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number is less than zero.", nameof(number));
            }

            if (number == 0)
            {
                return true;
            }

            int len = (int)Math.Log10(number) + 1;

            if (number % 10 != (int)(number / Math.Pow(10, len - 1)))
            {
                return false;
            }

            number = (int)(number % Math.Pow(10, len - 1)) / 10;

            return IsPalindromicNumber(number);
        }
    }
}
