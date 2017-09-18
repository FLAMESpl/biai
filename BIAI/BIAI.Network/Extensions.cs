using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BIAI.Network
{
    public static class Extensions
    {
        public static double NextNormalizedDouble(this Random r) => r.NextDouble();

        public static double Normalize(this double value, double min, double max) => (value - min) / (max - min);

        public static double Normalize(this int value, int min, int max) => (double)(value - min) / (max - min);

        public static double Normalize(this long value, long min, long max) => (double)(value - min) / (max - min);

        public static int MaxIndex<T>(this IEnumerable<T> sequence) where T : IComparable<T>
        {
            var maxIndex = -1;
            var maxValue = default(T);

            var index = 0;
            foreach (var value in sequence)
            {
                if (value.CompareTo(maxValue) > 0 || maxIndex == -1)
                {
                    maxIndex = index;
                    maxValue = value;
                }
                index++;
            }
            return maxIndex;
        }
    }
}
