using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorModel
{
    /// <summary>
    /// Класс Цилиндрический конденсатор
    /// </summary>
    [Serializable]
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

        /// <summary>
        /// Емкость цилиндрического конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                return Math.Round(2 * Math.PI * DielectricPermittivity * VACUUMPERMITTIVITY * HeightOfCylinder /
                    (Math.Log(ExterRadiusOfCylinder / InterRadiusOfCylinder)) * 1.0E12, 
                    2, MidpointRounding.AwayFromZero);
            }
             
        }

        /// <summary>
        /// Тип цилиндрического конденсатора
        /// </summary>
        public override string CapacitorType => "Цилиндрический";

    }
}
