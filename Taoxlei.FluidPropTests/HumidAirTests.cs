using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoxlei.FluidProp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taoxlei.FluidProp.Tests
{
    [TestClass()]
    public class HumidAirTests
    {

        double DryBulbTemperature = 308.15;
        double WetBulbTemperature = 300.15;
        double DewPointTemperature = 297.4944143265747;
        double Enthalpy = 84902.24585124892;
        double HumidityRatio = 0.0193738687870802;
        double Pressure = 101325;
        double RelativeHumidity = 0.5413230682444681;
        double SpecificVolume = 0.8998495651667421;

        [TestMethod()]
        public void TdbTwbPTest()
        {
            var r = HumidAir.TdbTwbP(DryBulbTemperature, WetBulbTemperature, Pressure);

            Assert.AreEqual(HumidityRatio, r[HumidAirParameter.HumidityRatio], HumidityRatio * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [TestMethod()]
        public void TdbHPTest()
        {
            var r = HumidAir.TdbHP(DryBulbTemperature, Enthalpy, Pressure);

            Assert.AreEqual(HumidityRatio, r[HumidAirParameter.HumidityRatio], HumidityRatio * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [TestMethod()]
        public void TdbWPTest()
        {
            var r = HumidAir.TdbWP(DryBulbTemperature, HumidityRatio, Pressure);

            Assert.AreEqual(WetBulbTemperature, r[HumidAirParameter.WetBulbTemperature], WetBulbTemperature * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [TestMethod()]
        public void TdbRHPTest()
        {
            var r = HumidAir.TdbRHP(DryBulbTemperature, RelativeHumidity, Pressure);

            Assert.AreEqual(HumidityRatio, r[HumidAirParameter.HumidityRatio], HumidityRatio * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [TestMethod()]
        public void HRHPTest()
        {
            var r = HumidAir.HRHP(Enthalpy, RelativeHumidity, Pressure);

            Assert.AreEqual(HumidityRatio, r[HumidAirParameter.HumidityRatio], HumidityRatio * 0.001);

            foreach (var kvp in r)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}