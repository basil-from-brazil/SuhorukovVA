using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Сферический конденсатор
    /// </summary>
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
                _exterRadiusOfSphere = ModelChecker.ValueChecker(value);
                if (ModelChecker.IsRadiusEntered(InterRadiusOfSphere))
                {
                    ModelChecker.RadiusChecker(InterRadiusOfSphere, value);
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
                _interRadiusOfSphere = ModelChecker.ValueChecker(value);
                if (ModelChecker.IsRadiusEntered(ExterRadiusOfSphere))
                {
                    ModelChecker.RadiusChecker(value, ExterRadiusOfSphere);
                }
            }
        }

        ///// <summary>
        ///// Конструктор класса Сферический конденсатор
        ///// </summary>
        ///// <param name="exterRadiusOfSphere">Внешний радиус 
        ///// сферического конденсатора</param>
        ///// <param name="interRadiusOfSphere">Внутренний радиус 
        ///// сферического конденсатора</param>
        ///// <param name="dielectricPermittivity">Диэлектрическая 
        ///// проницаемость диэлектрика конденсатора</param>
        //public SphericalCapacitor (double exterRadiusOfSphere, 
        //    double interRadiusOfSphere, double dielectricPermittivity)
        //{
        //    ExterRadiusOfSphere = exterRadiusOfSphere;
        //    InterRadiusOfSphere = interRadiusOfSphere;
        //    DielectricPermittivity = dielectricPermittivity;
        //}

        ///// <summary>
        ///// Конструктор класса Сферический конденсатор по умолчанию
        ///// </summary>
        //public SphericalCapacitor() : this(18, 12, 3.8)
        //{
        //}

        public override double Capacity
        {
            get
            {
                return 4 * Math.PI * DielectricPermittivity * VACUUMPERMITTIVITY * 
                       InterRadiusOfSphere * ExterRadiusOfSphere / 
                       (ExterRadiusOfSphere - InterRadiusOfSphere);
            }
        }
    }
}
