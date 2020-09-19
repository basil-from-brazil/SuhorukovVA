using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
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
                _plateArea = ModelCheck.ValueCheck(value);
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
                _gapBetweenPlates = ModelCheck.ValueCheck(value);
            }
        }

        /// <summary>
        /// Конструктор класса Плоский конденсатор
        /// </summary>
        /// <param name="plateArea">Площадь обкладок конденсатора</param>
        /// <param name="gapBetweenPlates">Зазор между обкладками 
        /// конденсатора</param>
        /// <param name="dielectricPermittivity">Диэлектрическая 
        /// проницаемость диэлектрика конденсатора</param>
        public PlateCapacitor(double plateArea, double gapBetweenPlates, double dielectricPermittivity)
        {
            PlateArea = plateArea;
            GapBetweenPlates = gapBetweenPlates;
            DielectricPermittivity = dielectricPermittivity;
        }

        /// <summary>
        /// Емкость плоского конденсатора
        /// </summary>
        public override double Capacity
        {
            get
            {
                return VACUUMPERMITTIVITY * DielectricPermittivity *
                    PlateArea / GapBetweenPlates;
            }
        }
    }
}
