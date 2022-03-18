using System;

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

        private static FluidOutput GetFluidOutput(AbstractState state)
        {
            var fo = new FluidOutput();
            fo.Compressibility = state.compressibility_factor();
            fo.Conductivity = state.conductivity();
            fo.CriticalPressure = state.p_critical();
            fo.CriticalTemperature = state.T_critical();
            fo.Density = state.rhomass();
            fo.DynamicViscosity = state.viscosity();
            fo.Enthalpy = state.hmass();
            fo.Entropy = state.smass();
            fo.InternalEnergy = state.umass();
            fo.MolarMass = state.molar_mass();
            fo.Phase = (FluidPhase)(int)state.phase(); // TODO
            fo.Prandtl = state.Prandtl();
            fo.Pressure = state.p();
            fo.Quality = state.Q();
            fo.SoundSpeed = fo.Phase == FluidPhase.TwoPhase ? double.NaN : state.speed_sound(); // TODO
            fo.SpecificHeat = state.cpmass();
            fo.SurfaceTension = state.surface_tension();
            fo.Temperature = state.T();
            fo.TriplePressure = state.p_triple();
            fo.TripleTemperature = state.Ttriple();
            return fo;
        }

        /// <summary>
        /// Get all output by Pressure and Enthalyy
        /// </summary>
        /// <param name="p">Pa</param>
        /// <param name="h">J/kg</param>
        /// <param name="fluid"></param>
        /// <returns></returns>
        public static FluidOutput PH(double p, double h, string fluid)
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
        public static FluidOutput PQ(double p, double q, string fluid)
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
                //case FluidParameter.Phase: return  (FluidPhase)(int)state.phase(); // TODO
                case FluidParameter.Prandtl: return state.Prandtl();
                case FluidParameter.Pressure: return state.p();
                case FluidParameter.Quality: return state.Q();
                //case FluidParameter.SoundSpeed: return (FluidParameter.Phase:= FluidPhase.TwoPhase ? double.NaN : state.speed_sound()); // TODO
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
