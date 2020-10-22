﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorModel
{
    /// <summary>
    /// Класс Сферический конденсатор
    /// </summary>
    [Serializable]
    public class SphericalCapacitor : CapacitorBase
    {
        /// <summary>
        /// Внешний радиус сферического конденсатора
        /// </summary>
        private double _exterRadiusOfSphere;

        /// <summary>
        /// Внутренний радиус сферического конденсатора
        /// </summary>
        private double _interRadiusOfSphere;

        /// <summary>
        /// Внешний радиус сферического конденсатора
        /// </summary>
        public double ExterRadiusOfSphere
        {
            get
            {
                return _exterRadiusOfSphere;
            }
            set
            {
                _exterRadiusOfSphere = ModelChecker.ValueChecker(value, 
                    nameof(ExterRadiusOfSphere));
                if (ModelChecker.IsRadiusEntered(InterRadiusOfSphere))
                {
                    ModelChecker.RadiusChecker(InterRadiusOfSphere, value, 
                        nameof(ExterRadiusOfSphere));
                }
            }
        }

        /// <summary>
        /// Внутренний радиус сферического конденсатора
        /// </summary>
        public double InterRadiusOfSphere
        {
            get
            {
                return _interRadiusOfSphere;
            }
            set
            {
                _interRadiusOfSphere = ModelChecker.ValueChecker(value, 
                    nameof(InterRadiusOfSphere));
                if (ModelChecker.IsRadiusEntered(ExterRadiusOfSphere))
                {
                    ModelChecker.RadiusChecker(value, ExterRadiusOfSphere, 
                        nameof(InterRadiusOfSphere));
                }
            }
        }

        /// <summary>
        /// Емкость сферического конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                return Math.Round(4 * Math.PI * DielectricPermittivity * VACUUMPERMITTIVITY * 
                       InterRadiusOfSphere * ExterRadiusOfSphere / 
                       (ExterRadiusOfSphere - InterRadiusOfSphere) * 1.0E12, 
                       2, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>
        /// Тип сферического конденсатора
        /// </summary>
        public override string CapacitorType => "Сферический";
    }
}
