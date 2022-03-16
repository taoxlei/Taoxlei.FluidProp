using System;
using System.Collections.Generic;
using System.Text;

namespace Taoxlei.FluidProp
{
    public class FluidOutput
    {
        /// <summary>
        /// -
        /// </summary>
        public double Compressibility { get; set; }

        /// <summary>
        /// W/m/K
        /// </summary>
        public double Conductivity { get; set; }

        /// <summary>
        /// Pa
        /// </summary>
        public double CriticalPressure { get; set; }
        
        /// <summary>
        /// K
        /// </summary>
        public double CriticalTemperature { get; set; }

        /// <summary>
        /// kg/m3
        /// </summary>
        public double Density { get; set; }

        /// <summary>
        /// Pa*s
        /// </summary>
        public double DynamicViscosity { get; set; }

        /// <summary>
        /// J/kg
        /// </summary>
        public double Enthalpy { get; set; }

        /// <summary>
        /// J/kg/K
        /// </summary>
        public double Entropy { get; set; }

        /// <summary>
        /// J/kg
        /// </summary>
        public double InternalEnergy { get; set; }

        /// <summary>
        /// kg/mol
        /// </summary>
        public double MolarMass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FluidPhase Phase { get; set; }

        /// <summary>
        /// -
        /// </summary>
        public double Prandtl { get; set; }

        /// <summary>
        /// Pa
        /// </summary>
        public double Pressure { get; set; }

        public double Quality { get; set; }

        /// <summary>
        /// m/s
        /// </summary>
        public double SoundSpeed { get; set; }

        /// <summary>
        /// J/kg/K
        /// </summary>
        public double SpecificHeat { get; set; }

        /// <summary>
        /// N/m
        /// </summary>
        public double SurfaceTension { get; set; }

        /// <summary>
        /// K
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Pa
        /// </summary>
        public double TriplePressure { get; set; }
        
        /// <summary>
        /// K
        /// </summary>
        public double TripleTemperature { get; set; }
    }
}
