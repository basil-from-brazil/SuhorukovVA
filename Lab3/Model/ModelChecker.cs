using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для проверки значений, которые присваются полям класса 
    /// Конденсатор
    /// </summary>
    public static class ModelChecker
    {
        /// <summary>
        /// Проверка корректности значений
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <returns>Проверенное значение</returns>
        public static double ValueChecker(double value)
        {
            if (double.IsNaN(value) || value <= 0)
            {
                throw new ArgumentException("The value cannot be equal to " +
                    "NaN or be less than zero or equal to zero!");
            }
            return value;
        }

        /// <summary>
        /// Проверка значений радиусов
        /// </summary>
        /// <param name="interRadius">Внутренний радиус</param>
        /// <param name="exterRadius">Внешний радиус</param>
        public static void RadiusChecker(double interRadius, double exterRadius)
        {
            if (interRadius >= exterRadius)
            {
                throw new ArgumentException("The internal radius cannot " +
                    "be greater or equal to the external radius! " +
                    "Please check the values of radiuses!\n");
            }
        }

        /// <summary>
        /// Проверка введен ли радиус
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        public static bool IsRadiusEntered(double radius)
        {
            return radius != 0.0;
        }
    }
}
