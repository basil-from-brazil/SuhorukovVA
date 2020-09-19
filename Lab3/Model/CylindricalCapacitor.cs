﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Цилиндрический конденсатор
    /// </summary>
    public class CylindricalCapacitor : CapacitorBase
    {
        /// <summary>
        /// Высота цилиндрического конденсатора
        /// </summary>
        private double _heightOfCylinder;

        /// <summary>
        /// Внешний радиус цилиндрического конденсатора
        /// </summary>
        private double _exterRadiusOfCylinder;

        /// <summary>
        /// Внтуренний радиус цилиндрического конденсатора
        /// </summary>
        private double _interRadiusOfCylinder;

        /// <summary>
        /// Высота цилиндрического конденсатора
        /// </summary>
        public double HeightOfCylinder
        {
            get
            {
                return _heightOfCylinder;
            }
            set
            {
                _heightOfCylinder = ModelChecker.ValueChecker(value);
            }
        }

        /// <summary>
        /// Внешний радиус цилиндрического конденсатора
        /// </summary>
        public double ExterRadiusOfCylinder
        {
            get
            {
                return _exterRadiusOfCylinder;
            }
            set
            {
                _exterRadiusOfCylinder = ModelChecker.ValueChecker(value);
                if (ModelChecker.IsRadiusEntered(InterRadiusOfCylinder))
                {
                    ModelChecker.RadiusChecker(InterRadiusOfCylinder, value);
                }
            }
        }

        /// <summary>
        /// Внутренний радиус цилиндрического конденсатора
        /// </summary>
        public double InterRadiusOfCylinder
        {
            get
            {
                return _interRadiusOfCylinder;
            }
            set
            {
                _interRadiusOfCylinder = ModelChecker.ValueChecker(value);
                if (ModelChecker.IsRadiusEntered(ExterRadiusOfCylinder))
                {
                    ModelChecker.RadiusChecker(value,ExterRadiusOfCylinder);
                }
            }
        }

        ///// <summary>
        ///// Конструктор класса Цилиндрический конденсатор
        ///// </summary>
        ///// <param name="heightOfCylinder">Высота цилиндрического 
        ///// конденсатора</param>
        ///// <param name="exterRadiusOfCylinder">Внешний радиус 
        ///// цилиндрического конденсатора</param>
        ///// <param name="interRadiusOfCylinder">Внутренний радиус 
        ///// цилиндрического конденсатора</param>
        ///// <param name="dielectricPermittivity">Диэлектрическая 
        ///// проницаемость диэлектрика конденсатора</param>
        //public CylindricalCapacitor(double heightOfCylinder, 
        //    double exterRadiusOfCylinder, double interRadiusOfCylinder, 
        //    double dielectricPermittivity)
        //{
        //    HeightOfCylinder = heightOfCylinder;
        //    ExterRadiusOfCylinder = exterRadiusOfCylinder;
        //    InterRadiusOfCylinder = interRadiusOfCylinder;
        //    DielectricPermittivity = dielectricPermittivity;
        //}

        /// <summary>
        /// Конструктор класса Цилиндрический конденсатор по умолчанию
        /// </summary>
        //public CylindricalCapacitor() : this(12, 18, 6, 3.8)
        //{
        //    HeightOfCylinder = 12;
        //    ExterRadiusOfCylinder = 18;
        //    InterRadiusOfCylinder = 6;
        //    DielectricPermittivity = 3.8;
        //}

        /// <summary>
        /// Емкость цилиндрического конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                return 2 * Math.PI * DielectricPermittivity * VACUUMPERMITTIVITY * HeightOfCylinder /
                    (Math.Log(ExterRadiusOfCylinder / InterRadiusOfCylinder));
            }
             
        }
    }
}
