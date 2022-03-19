using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Taoxlei.FluidPropBenchmarks
{
    [AllStatisticsColumn,AllCategoriesFilter]
    public class OneOutputVsManyOutput
    {
        private readonly double p;
        private readonly double h;

        public OneOutputVsManyOutput()
        {
            p = 1000e3;
            h = 250e3;
        }

        [Benchmark]
        public double OneOutput()
        {
            var r = FluidProp.Fluid.PH(p, h, "R32", FluidProp.FluidParameter.Density);
            return r;
        }

        [Benchmark]
        public double ManyOutput()
        {
            var r = FluidProp.Fluid.PH(p, h, "R32");
            return r[FluidProp.FluidParameter.Density];
        }
    }
}
