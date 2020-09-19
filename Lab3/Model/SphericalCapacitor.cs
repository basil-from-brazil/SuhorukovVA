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
                _exterRadiusOfSphere = ModelCheck.ValueCheck(value);
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
                _interRadiusOfSphere = ModelCheck.ValueCheck(value);
            }
        }

        /// <summary>
        /// Конструктор класса Сферический конденсатор
        /// </summary>
        /// <param name="exterRadiusOfSphere">Внешний радиус 
        /// сферического конденсатора</param>
        /// <param name="interRadiusOfSphere">Внутренний радиус 
        /// сферического конденсатора</param>
        /// <param name="dielectricPermittivity">Диэлектрическая 
        /// проницаемость диэлектрика конденсатора</param>
        public SphericalCapacitor (double exterRadiusOfSphere, double 
            interRadiusOfSphere, double dielectricPermittivity)
        {
            ExterRadiusOfSphere = exterRadiusOfSphere;
            InterRadiusOfSphere = interRadiusOfSphere;
            DielectricPermittivity = dielectricPermittivity;
        }

        public override double Capacity
        {
            get
            {
                ModelCheck.RadiusCheck(InterRadiusOfSphere,ExterRadiusOfSphere);
                return 4 * Math.PI * DielectricPermittivity * 
                    VACUUMPERMITTIVITY * InterRadiusOfSphere * 
                    ExterRadiusOfSphere / (ExterRadiusOfSphere 
                    - InterRadiusOfSphere);
            }
        }
    }
}
