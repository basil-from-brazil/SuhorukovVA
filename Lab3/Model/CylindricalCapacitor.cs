using System;
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
                _heightOfCylinder = ModelCheck.ValueCheck(value);
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
                _exterRadiusOfCylinder = ModelCheck.ValueCheck(value);
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
                _interRadiusOfCylinder = ModelCheck.ValueCheck(value);
            }
        }

        /// <summary>
        /// Конструктор класса Цилиндрический конденсатор
        /// </summary>
        /// <param name="heightOfCylinder">Высота цилиндрического 
        /// конденсатора</param>
        /// <param name="exterRadiusOfCylinder">Внешний радиус 
        /// цилиндрического конденсатора</param>
        /// <param name="interRadiusOfCylinder">Внутренний радиус 
        /// цилиндрического конденсатора</param>
        /// <param name="dielectricPermittivity">Диэлектрическая 
        /// проницаемость диэлектрика конденсатора</param>
        public CylindricalCapacitor(double heightOfCylinder, double 
            exterRadiusOfCylinder, double interRadiusOfCylinder, 
            double dielectricPermittivity)
        {
            HeightOfCylinder = heightOfCylinder;
            ExterRadiusOfCylinder = exterRadiusOfCylinder;
            InterRadiusOfCylinder = interRadiusOfCylinder;
            DielectricPermittivity = dielectricPermittivity;
        }

        /// <summary>
        /// Конструктор класса Цилиндрический конденсатор по умолчанию
        /// </summary>
        public CylindricalCapacitor() : this(12, 18, 6, 3.8)
        {
        }

        /// <summary>
        /// Емкость цилиндрического конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                ModelCheck.RadiusCheck(InterRadiusOfCylinder, ExterRadiusOfCylinder);
                return 2 * Math.PI * DielectricPermittivity * 
                VACUUMPERMITTIVITY * HeightOfCylinder / 
                (Math.Log(ExterRadiusOfCylinder / 
                InterRadiusOfCylinder));
            }
             
        }
    }
}
