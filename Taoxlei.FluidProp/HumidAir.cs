using System;
using System.Collections.Generic;
using System.Text;

namespace Taoxlei.FluidProp
{
    public static class HumidAir
    {
        public static Dictionary<HumidAirParameter, double> TdbTwbP(double Tdb, double Twb, double P)
        {
            return new Dictionary<HumidAirParameter, double>
            {
                { HumidAirParameter.DryBulbTemperature, Tdb },
                { HumidAirParameter.WetBulbTemperature, Twb },
                { HumidAirParameter.DewPointTemperature, CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "Twb", Twb, "P", P) },
                { HumidAirParameter.Enthalpy, CoolProp.HAPropsSI("H", "Tdb", Tdb, "Twb", Twb, "P", P) },
                { HumidAirParameter.HumidityRatio, CoolProp.HAPropsSI("W", "Tdb", Tdb, "Twb", Twb, "P", P) },
                { HumidAirParameter.Pressure, P },
                { HumidAirParameter.RelativeHumidity, CoolProp.HAPropsSI("RH", "Tdb", Tdb, "Twb", Twb, "P", P) },
                { HumidAirParameter.SpecificVolume, CoolProp.HAPropsSI("V", "Tdb", Tdb, "Twb", Twb, "P", P) }
            };
        }

        public static double TdbTwbP(double Tdb, double Twb, double P, HumidAirParameter hap)
        {
            switch (hap)
            {
                case HumidAirParameter.DryBulbTemperature: return Tdb;
                case HumidAirParameter.WetBulbTemperature: return Twb;
                case HumidAirParameter.DewPointTemperature: return CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "Twb", Twb, "P", P);
                case HumidAirParameter.Enthalpy: return CoolProp.HAPropsSI("H", "Tdb", Tdb, "Twb", Twb, "P", P);
                case HumidAirParameter.HumidityRatio: return CoolProp.HAPropsSI("W", "Tdb", Tdb, "Twb", Twb, "P", P);
                case HumidAirParameter.Pressure: return P;
                case HumidAirParameter.RelativeHumidity: return CoolProp.HAPropsSI("RH", "Tdb", Tdb, "Twb", Twb, "P", P);
                case HumidAirParameter.SpecificVolume: return CoolProp.HAPropsSI("V", "Tdb", Tdb, "Twb", Twb, "P", P);
                default: throw new NotImplementedException();
            }
        }

        public static Dictionary<HumidAirParameter, double> TdbHP(double Tdb, double H, double P)
        {
            return new Dictionary<HumidAirParameter, double>
            {
                { HumidAirParameter.DryBulbTemperature, Tdb },
                { HumidAirParameter.WetBulbTemperature, CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "H", H, "P", P) },
                { HumidAirParameter.DewPointTemperature, CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "H", H, "P", P) },
                { HumidAirParameter.Enthalpy, H }, 
                { HumidAirParameter.HumidityRatio, CoolProp.HAPropsSI("W", "Tdb", Tdb, "H", H, "P", P) },
                { HumidAirParameter.Pressure, P },
                { HumidAirParameter.RelativeHumidity, CoolProp.HAPropsSI("RH", "Tdb", Tdb, "H", H, "P", P) },
                { HumidAirParameter.SpecificVolume, CoolProp.HAPropsSI("V", "Tdb", Tdb, "H", H, "P", P) },
            };
        }

        public static double TdbHP(double Tdb, double H, double P, HumidAirParameter hap)
        {
            switch (hap)
            {
                case HumidAirParameter.DryBulbTemperature: return Tdb;
                case HumidAirParameter.WetBulbTemperature: return CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "H", H, "P", P);
                case HumidAirParameter.DewPointTemperature: return CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "H", H, "P", P);
                case HumidAirParameter.Enthalpy: return H;
                case HumidAirParameter.HumidityRatio: return CoolProp.HAPropsSI("W", "Tdb", Tdb, "H", H, "P", P);
                case HumidAirParameter.Pressure: return P;
                case HumidAirParameter.RelativeHumidity: return CoolProp.HAPropsSI("RH", "Tdb", Tdb, "H", H, "P", P);
                case HumidAirParameter.SpecificVolume: return CoolProp.HAPropsSI("V", "Tdb", Tdb, "H", H, "P", P);
                default: throw new NotImplementedException();
            }
        }

        public static Dictionary<HumidAirParameter, double> TdbWP(double Tdb, double W, double P)
        {
            return new Dictionary<HumidAirParameter, double>
            {
                { HumidAirParameter.DryBulbTemperature, Tdb },
                { HumidAirParameter.WetBulbTemperature, CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "W", W, "P", P) },
                { HumidAirParameter.DewPointTemperature, CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "W", W, "P", P) },
                { HumidAirParameter.Enthalpy, CoolProp.HAPropsSI("H", "Tdb", Tdb, "W", W, "P", P) },
                { HumidAirParameter.HumidityRatio, W },
                { HumidAirParameter.Pressure, P },
                { HumidAirParameter.RelativeHumidity, CoolProp.HAPropsSI("RH", "Tdb", Tdb, "W", W, "P", P) },
                { HumidAirParameter.SpecificVolume, CoolProp.HAPropsSI("V", "Tdb", Tdb, "W", W, "P", P) },
            };
        }

        public static double TdbWP(double Tdb, double W, double P, HumidAirParameter hap)
        {
            switch (hap)
            {
                case HumidAirParameter.DryBulbTemperature: return Tdb;
                case HumidAirParameter.WetBulbTemperature: return CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "W", W, "P", P);
                case HumidAirParameter.DewPointTemperature: return CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "W", W, "P", P);
                case HumidAirParameter.Enthalpy: return CoolProp.HAPropsSI("H", "Tdb", Tdb, "W", W, "P", P);
                case HumidAirParameter.HumidityRatio: return W;
                case HumidAirParameter.Pressure: return P;
                case HumidAirParameter.RelativeHumidity: return CoolProp.HAPropsSI("RH", "Tdb", Tdb, "W", W, "P", P);
                case HumidAirParameter.SpecificVolume: return CoolProp.HAPropsSI("V", "Tdb", Tdb, "W", W, "P", P);
                default: throw new NotImplementedException();
            }
        }

        public static Dictionary<HumidAirParameter, double> TdbRHP(double Tdb, double RH, double P)
        {
            return new Dictionary<HumidAirParameter, double>
            {
                { HumidAirParameter.DryBulbTemperature, Tdb },
                { HumidAirParameter.WetBulbTemperature, CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "RH", RH, "P", P) },
                { HumidAirParameter.DewPointTemperature, CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "RH", RH, "P", P) },
                { HumidAirParameter.Enthalpy, CoolProp.HAPropsSI("H", "Tdb", Tdb, "RH", RH, "P", P) },
                { HumidAirParameter.HumidityRatio, CoolProp.HAPropsSI("W", "Tdb", Tdb, "RH", RH, "P", P) },
                { HumidAirParameter.Pressure, P },
                { HumidAirParameter.RelativeHumidity, RH },
                { HumidAirParameter.SpecificVolume, CoolProp.HAPropsSI("V", "Tdb", Tdb, "RH", RH, "P", P) },
            };
        }

        public static double TdbRHP(double Tdb, double RH, double P, HumidAirParameter hap)
        {
            switch (hap)
            {
                case HumidAirParameter.DryBulbTemperature: return Tdb;
                case HumidAirParameter.WetBulbTemperature: return CoolProp.HAPropsSI("Twb", "Tdb", Tdb, "RH", RH, "P", P);
                case HumidAirParameter.DewPointTemperature: return CoolProp.HAPropsSI("Tdp", "Tdb", Tdb, "RH", RH, "P", P);
                case HumidAirParameter.Enthalpy: return CoolProp.HAPropsSI("H", "Tdb", Tdb, "RH", RH, "P", P);
                case HumidAirParameter.HumidityRatio: return CoolProp.HAPropsSI("W", "Tdb", Tdb, "RH", RH, "P", P);
                case HumidAirParameter.Pressure: return P;
                case HumidAirParameter.RelativeHumidity: return RH;
                case HumidAirParameter.SpecificVolume: return CoolProp.HAPropsSI("V", "Tdb", Tdb, "RH", RH, "P", P);
                default: throw new NotImplementedException();
            }
        }

        public static Dictionary<HumidAirParameter, double> HRHP(double H, double RH, double P)
        {
            return new Dictionary<HumidAirParameter, double>
            {
                { HumidAirParameter.DryBulbTemperature, CoolProp.HAPropsSI("Tdb", "H", H, "RH", RH, "P", P) },
                { HumidAirParameter.WetBulbTemperature, CoolProp.HAPropsSI("Twb", "H", H, "RH", RH, "P", P) },
                { HumidAirParameter.DewPointTemperature, CoolProp.HAPropsSI("Tdp", "H", H, "RH", RH, "P", P) },
                { HumidAirParameter.Enthalpy, H },
                { HumidAirParameter.HumidityRatio, CoolProp.HAPropsSI("W", "H", H, "RH", RH, "P", P) },
                { HumidAirParameter.Pressure, P },
                { HumidAirParameter.RelativeHumidity, RH },
                { HumidAirParameter.SpecificVolume, CoolProp.HAPropsSI("V", "H", H, "RH", RH, "P", P) },
            };
        }

        public static double HRHP(double H, double RH, double P, HumidAirParameter hap)
        {
            switch (hap)
            {
                case HumidAirParameter.DryBulbTemperature: return CoolProp.HAPropsSI("Tdb", "H", H, "RH", RH, "P", P);
                case HumidAirParameter.WetBulbTemperature: return CoolProp.HAPropsSI("Twb", "H", H, "RH", RH, "P", P);
                case HumidAirParameter.DewPointTemperature: return CoolProp.HAPropsSI("Tdp", "H", H, "RH", RH, "P", P);
                case HumidAirParameter.Enthalpy: return H;
                case HumidAirParameter.HumidityRatio: return CoolProp.HAPropsSI("W", "H", H, "RH", RH, "P", P);
                case HumidAirParameter.Pressure: return P;
                case HumidAirParameter.RelativeHumidity: return RH;
                case HumidAirParameter.SpecificVolume: return CoolProp.HAPropsSI("V", "H", H, "RH", RH, "P", P);
                default: throw new NotImplementedException();
            }
        }

    }
}
