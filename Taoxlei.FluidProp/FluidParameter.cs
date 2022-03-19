using System;
using System.Collections.Generic;
using System.Text;

namespace Taoxlei.FluidProp
{
    public enum FluidParameter
    {
        /// <summary>
        /// -
        /// </summary>
        Compressibility,

        /// <summary>
        /// W/m/K
        /// </summary>
        Conductivity,

        /// <summary>
        /// Pa
        /// </summary>
        CriticalPressure,

        /// <summary>
        /// K
        /// </summary>
        CriticalTemperature,

        /// <summary>
        /// kg/m3
        /// </summary>
        Density,

        /// <summary>
        /// Pa*s
        /// </summary>
        DynamicViscosity,

        /// <summary>
        /// J/kg
        /// </summary>
        Enthalpy,

        /// <summary>
        /// J/kg/K
        /// </summary>
        Entropy,

        /// <summary>
        /// J/kg
        /// </summary>
        InternalEnergy,

        /// <summary>
        /// kg/mol
        /// </summary>
        MolarMass,


        /// <summary>
        /// -
        /// </summary>
        Prandtl,

        /// <summary>
        /// Pa
        /// </summary>
        Pressure,

        Quality,

        /// <summary>
        /// J/kg/K
        /// </summary>
        SpecificHeat,

        /// <summary>
        /// N/m
        /// </summary>
        SurfaceTension,

        /// <summary>
        /// K
        /// </summary>
        Temperature,

        /// <summary>
        /// Pa
        /// </summary>
        TriplePressure,

        /// <summary>
        /// K
        /// </summary>
        TripleTemperature,
    }
}
