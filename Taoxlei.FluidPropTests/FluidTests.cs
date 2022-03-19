using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoxlei.FluidProp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taoxlei.FluidProp.Tests
{
    [TestClass()]
    public class FluidTests
    {
        [TestMethod()]
        public void PHTest()
        {
            double p = 1000e3;
            double h = 250e3;
            var r = Fluid.PH(p, h, "R32");

            double expectedDensity = 183.0023964456368;
            Assert.AreEqual(expectedDensity, r[FluidParameter.Density], expectedDensity*0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [TestMethod()]
        public void PQTest()
        {
            double p = 1000e3;
            double q = 0.1257649745484279;
            var r = Fluid.PQ(p, q, "R32");

            double expectedDensity = 183.0023964456368;
            Assert.AreEqual(expectedDensity, r[FluidParameter.Density], expectedDensity * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}