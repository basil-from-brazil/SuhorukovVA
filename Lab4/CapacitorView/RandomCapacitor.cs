using CapacitorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitorView
{
    /// <summary>
    /// Класс для генерации случайного конденсатора
    /// </summary>
    public static class RandomCapacitor
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Максимальное значение для площади, зазора, высоты
        /// </summary>
        private const int MAXVALUE = 1000;

        /// <summary>
        /// Минимальное значение для площади, зазора, высоты
        /// </summary>
        private const int MINVALUE = 200;

        /// <summary>
        /// Значение делителя для площади, зазора, высоты
        /// </summary>
        private const double DIVIDER = 10000.0;

        /// <summary>
        /// Минимальное значение для диэлектрической проницаемости
        /// </summary>
        private const int MINVALUEFORPERMITTIVITY = 10;

        /// <summary>
        /// Максимальное значение для диэлектрической проницаемости
        /// </summary>
        private const int MAXVALUEFORPERMITTIVITY = 100;

        /// <summary>
        /// Значение делителя для диэлектрической проницаемости
        /// </summary>
        private const double DIVIDERFORPERMITTIVITY = 10.0;

        /// <summary>
        /// Минимальное значение для внутреннего радиуса
        /// </summary>
        private const int MINVALUEFORINTERRADUIS = 2000;

        /// <summary>
        /// Максимальное значение для внутреннего радиуса
        /// </summary>
        private const int MAXVALUEFORINTERRADIUS = 5000;

        /// <summary>
        /// Минимальное значение для внешнего радиуса
        /// </summary>
        private const int MINVALUEFOREXTERRADIUS = 6000;

        /// <summary>
        /// Максимальное значение для внешнего радиуса
        /// </summary>
        private const int MAXVALUEFOREXTERRADIUS = 9000;

        /// <summary>
        /// Значение делителей для радиусов
        /// </summary>
        private const double DIVIDERFORRADIUSES = 100000.0;

        /// <summary>
        /// Сгенерировать случайный конденсатор
        /// </summary>
        /// <returns>Сгенерированный объект класса CapacitorBase</returns>
        public static CapacitorBase GetRandomCapacitor()
        {
            var capacitorType = _random.Next(0, 3);

            switch (capacitorType)
            {
                case 0:
                {
                    return GetRandomPlateCapacitor();
                }
                case 1:
                {
                    return GetRandomCylindricalCapacitor();
                }
                case 2:
                {
                    return GetRandomSphericalCapacitor();
                }
                default:
                {
                    throw new ArgumentException("Тип конденсатора неизвестен!");
                }
            }
        }

        /// <summary>
        /// Сгенерировать случайное число double с использование чисел int
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="divider">Делитель</param>
        /// <returns></returns>
        public static double GetRandomDouble(int minValue, int maxValue, 
            double divider)
        {
            var buffer = Convert.ToDouble(_random.Next(minValue, maxValue));
            return buffer / divider;
        }
        
        /// <summary>
        /// Сгенерировать случайный плоский конденсатор
        /// </summary>
        /// <returns>Случайный плоский конденсатор</returns>
        public static CapacitorBase GetRandomPlateCapacitor()
        {
            var plateCapacitor = new PlateCapacitor
            {
                DielectricPermittivity = GetRandomDouble(MINVALUEFORPERMITTIVITY,
                MAXVALUEFORPERMITTIVITY, DIVIDERFORPERMITTIVITY),
                PlateArea = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                GapBetweenPlates = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER)
            };
            return plateCapacitor;
        }

        /// <summary>
        /// Сгенерировать случайный цилиндрический конденсатор
        /// </summary>
        /// <returns>Случайный цилиндрический конденсатор</returns>
        public static CapacitorBase GetRandomCylindricalCapacitor()
        {
            var cylindricalCapacitor = new CylindricalCapacitor
            {
                DielectricPermittivity = GetRandomDouble(MINVALUEFORPERMITTIVITY,
                MAXVALUEFORPERMITTIVITY, DIVIDERFORPERMITTIVITY),
                HeightOfCylinder = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                InterRadiusOfCylinder = GetRandomDouble(MINVALUEFORINTERRADUIS, 
                MAXVALUEFORINTERRADIUS, DIVIDERFORRADIUSES),
                ExterRadiusOfCylinder = GetRandomDouble(MINVALUEFOREXTERRADIUS,
                MAXVALUEFOREXTERRADIUS, DIVIDERFORRADIUSES)
            };
            return cylindricalCapacitor;
        }

        /// <summary>
        /// Сгенерировать случайный сферический конденсатор
        /// </summary>
        /// <returns>Случайный сферический конденсатор</returns>
        public static CapacitorBase GetRandomSphericalCapacitor()
        {
            var sphericalCapacitor = new SphericalCapacitor
            {
                DielectricPermittivity = GetRandomDouble(MINVALUEFORPERMITTIVITY,
                MAXVALUEFORPERMITTIVITY, DIVIDERFORPERMITTIVITY),
                InterRadiusOfSphere = GetRandomDouble(MINVALUEFORINTERRADUIS,
                MAXVALUEFORINTERRADIUS, DIVIDERFORRADIUSES),
                ExterRadiusOfSphere = GetRandomDouble(MINVALUEFOREXTERRADIUS,
                MAXVALUEFOREXTERRADIUS, DIVIDERFORRADIUSES)
            };
            return sphericalCapacitor;
        }
    }
}
