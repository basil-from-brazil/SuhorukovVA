using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorModel
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
                throw new ArgumentNullException($"{value}", 
                    "Значение не может быть равно NaN " +
                    "или быть меньше или равно нулю! " +
                    "Пожалуйста, поверьте значение!\n");
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
                throw new ArgumentOutOfRangeException($"\nВнешний радиус: {interRadius}" +
                    $"\nВнутренний радиус: {exterRadius}", 
                    "Внутренний радиус не может " +
                    "быть больше или равен внешнему радиусу! " +
                    "Пожалуйста, проверьте значения радиусов!\n");
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
