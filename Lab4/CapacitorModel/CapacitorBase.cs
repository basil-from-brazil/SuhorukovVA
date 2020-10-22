using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorModel
{
    /// <summary>
    /// Базовый класс Конденсатор
    /// </summary>
    [Serializable]
    public abstract class CapacitorBase
    {
        /// <summary>
        /// Диэлектрическая проницаемость вакуума
        /// </summary>
        private protected const double VACUUMPERMITTIVITY = 8.85E-12;

        /// <summary>
        /// Диэлектрическая проницаемость диэлектрика конденсатора
        /// </summary>
        private double _dielectricPermittivity;

        /// <summary>
        /// Диэлектрическая проницаемость диэлектрика конденсатора
        /// </summary>
        public double DielectricPermittivity
        {
            get
            {
                return _dielectricPermittivity;
            }
            set
            {
                _dielectricPermittivity = ModelChecker.ValueChecker(value, 
                    nameof(DielectricPermittivity));
            }
        }

        /// <summary>
        /// Емкость конденсатора
        /// </summary>
        public abstract double Capacity { get; }

        /// <summary>
        /// Тип конденсатора
        /// </summary>
        public abstract string CapacitorType { get; }
    }
}
