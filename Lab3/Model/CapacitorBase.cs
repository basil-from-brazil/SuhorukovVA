using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Базовый класс Конденсатор
    /// </summary>
    public abstract class CapacitorBase
    {
        /// <summary>
        /// Диэлектрическая проницаемость вакуума
        /// </summary>
        private protected const double VACUUMPERMITTIVITY = 8.85e-12;

        /// <summary>
        /// Диэлектрическая проницаемость диэлектрика конденсатора
        /// </summary>
        private double _dielectricPermittivity;

        public double DielectricPermittivity
        {
            get
            {
                return _dielectricPermittivity;
            }
            set
            {
                _dielectricPermittivity=ModelCheck.ValueCheck(value);
            }
        }

        /// <summary>
        /// Емкость конденсатора
        /// </summary>
        public abstract double Capacity { get; }
    }
}
