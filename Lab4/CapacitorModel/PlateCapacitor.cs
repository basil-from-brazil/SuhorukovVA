using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorModel
{
    /// <summary>
    /// Класс Плоский конденсатор
    /// </summary>
    public class PlateCapacitor : CapacitorBase
    {
        /// <summary>
        /// Площадь обкладок конденсатора
        /// </summary>
        private double _plateArea;

        /// <summary>
        /// Зазор между обкладками конденсатора
        /// </summary>
        private double _gapBetweenPlates;

        /// <summary>
        /// Площадь обкладок конденсатора
        /// </summary>
        public double PlateArea
        {
            get
            {
                return _plateArea;
            }
            set
            {
                _plateArea = ModelChecker.ValueChecker(value);
            }
        }

        /// <summary>
        /// Зазор между обкладками конденсатора
        /// </summary>
        public double GapBetweenPlates
        {
            get
            {
                return _gapBetweenPlates;
            }
            set
            {
                _gapBetweenPlates = ModelChecker.ValueChecker(value);
            }
        }
        
        /// <summary>
        /// Емкость плоского конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                return VACUUMPERMITTIVITY * DielectricPermittivity * PlateArea / 
                       GapBetweenPlates;
            }
        }

        /// <summary>
        /// Тип плоского конденсатора
        /// </summary>
        public override string CapacitorType => "Плоский";
    }
}
