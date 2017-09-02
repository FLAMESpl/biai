using System;

namespace BIAI.Network
{
    public static class Extensions
    {
        public static double NextNormalizedDouble(this Random r) => r.NextDouble() * 2 - 1;

        public static double Normalize(this double value, double min, double max) => (value - min) / (max - min);

        public static double Normalize(this int value, int min, int max) => (double)(value - min) / (max - min);

        public static double Normalize(this long value, long min, long max) => (double)(value - min) / (max - min);
    }
}
