using BIAI.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BIAI.Tests
{
    public static class Extensions
    {
        public static double[] NextArrayOfNormalizedDoubles(this Random random, int count)
        {
            var values = new double[count];
            for (int i = 0; i < count; i++)
            {
                values[i] = random.NextNormalizedDouble();
            }
            return values;
        }

        public static void AssertIsNormalized(double value)
        {
            Assert.IsTrue(value >= 0 && value <= 1);
        }
    }
}
