using System;

namespace BIAI.Network
{
    public static class Extensions
    {
        public static double NextNormalizedDouble(this Random r) => r.NextDouble() * 2 - 1;
    }
}
