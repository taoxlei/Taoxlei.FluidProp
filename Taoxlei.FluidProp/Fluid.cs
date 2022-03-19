using System;
using System.Collections.Generic;

namespace Taoxlei.FluidProp
{
    public static class Fluid
    {
        private static AbstractState _state;

        private static AbstractState GetAbstractState(string fluid)
        {
            if (_state == null)
            {
                _state = AbstractState.factory("HEOS", fluid);
            }
            return _state;
        }

        private static Dictionary<FluidParameter, double> GetFluidOutput(AbstractState state)
        {
            var fo = new Dictionary<FluidParameter, double>
            {
                { FluidParameter.Compressibility, state.compressibility_factor() },
                { FluidParameter.Conductivity, state.conductivity() },
                { FluidParameter.CriticalPressure, state.p_critical() },
                { FluidParameter.CriticalTemperature, state.T_critical() },
                { FluidParameter.Density, state.rhomass() },
                { FluidParameter.DynamicViscosity, state.viscosity() },
                { FluidParameter.Enthalpy, state.hmass() },
                { FluidParameter.Entropy, state.smass() },
                { FluidParameter.InternalEnergy, state.umass() },
                { FluidParameter.MolarMass, state.molar_mass() },
                { FluidParameter.Prandtl, state.Prandtl() },
                { FluidParameter.Pressure, state.p() },
                { FluidParameter.Quality, state.Q() },
                { FluidParameter.SpecificHeat, state.cpmass() },
                { FluidParameter.SurfaceTension, state.surface_tension() },
                { FluidParameter.Temperature, state.T() },
                { FluidParameter.TriplePressure, state.p_triple() },
                { FluidParameter.TripleTemperature, state.Ttriple() },
            };
            return fo;
        }

        /// <summary>
        /// Get all output by Pressure and Enthalyy
        /// </summary>
        /// <param name="p">Pa</param>
        /// <param name="h">J/kg</param>
        /// <param name="fluid"></param>
        /// <returns></returns>
        public static Dictionary<FluidParameter, double> PH(double p, double h, string fluid)
        {
            var state = GetAbstractState(fluid);
            state.update(input_pairs.HmassP_INPUTS, h, p);
            return GetFluidOutput(state);
        }

        /// <summary>
        /// Get all output by Pressure and Quality
        /// </summary>
        /// <param name="p">Pa</param>
        /// <param name="q"></param>
        /// <param name="fluid"></param>
        /// <returns></returns>
        public static Dictionary<FluidParameter, double> PQ(double p, double q, string fluid)
        {
            var state = GetAbstractState(fluid);
            state.update(input_pairs.PQ_INPUTS, p, q);
            return GetFluidOutput(state);
        }

        private static double GetOneOutput(AbstractState state, FluidParameter fp)
        {
            switch (fp)
            {
                case FluidParameter.Compressibility: return state.compressibility_factor();
                case FluidParameter.Conductivity: return state.conductivity();
                case FluidParameter.CriticalPressure: return state.p_critical();
                case FluidParameter.CriticalTemperature: return state.T_critical();
                case FluidParameter.Density: return state.rhomass();
                case FluidParameter.DynamicViscosity: return state.viscosity();
                case FluidParameter.Enthalpy: return state.hmass();
                case FluidParameter.Entropy: return state.smass();
                case FluidParameter.InternalEnergy: return state.umass();
                case FluidParameter.MolarMass: return state.molar_mass();
                case FluidParameter.Prandtl: return state.Prandtl();
                case FluidParameter.Pressure: return state.p();
                case FluidParameter.Quality: return state.Q();
                case FluidParameter.SpecificHeat: return state.cpmass();
                case FluidParameter.SurfaceTension: return state.surface_tension();
                case FluidParameter.Temperature: return state.T();
                case FluidParameter.TriplePressure: return state.p_triple();
                case FluidParameter.TripleTemperature: return state.Ttriple();
                default: throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Get a single output by Pressure and Enthalpy
        /// </summary>
        /// <param name="p">Pa</param>
        /// <param name="h">J/kg</param>
        /// <param name="fluid"></param>
        /// <param name="fp"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double PH(double p, double h, string fluid, FluidParameter fp)
        {
            var state = GetAbstractState(fluid);
            state.update(input_pairs.HmassP_INPUTS, h, p);
            return GetOneOutput(state, fp);
        }

        /// <summary>
        /// Get a single output by Pressure and Quality
        /// </summary>
        /// <param name="p">Pa</param>
        /// <param name="q"></param>
        /// <param name="fluid"></param>
        /// <param name="fp"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double PQ(double p, double q, string fluid, FluidParameter fp)
        {
            var state = GetAbstractState(fluid);
            state.update(input_pairs.PQ_INPUTS, p, q);
            return GetOneOutput(state, fp);
        }

    }
}
