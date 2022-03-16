﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void HPTest()
        {
            double p = 1000e3;
            double h = 250e3;
            var r = Fluid.PH(p, h, "R32");

            foreach (var pi in r.GetType().GetProperties())
            {
                Console.WriteLine($"{pi.Name}: {pi.GetValue(r)?.ToString()}");
            }
        }
    }
}