using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Класс для проверки введенных пользователем данных
    /// </summary>
    public static class ConsoleInput
    {
        /// <summary>
        /// Ввод данных о плоском конденсаторе с клавиатуры
        /// </summary>
        /// <returns>Созданный экземпляр класса Плоский конденсатор</returns>
        public static PlateCapacitor GetNewPlateCapacitorFromKeyboard()
        {
            var newPlateCapacitorFromKeyBoard = new PlateCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Plate Area: ");
                    newPlateCapacitorFromKeyBoard.PlateArea = 
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Gap Between PLates: ");
                    newPlateCapacitorFromKeyBoard.GapBetweenPlates = 
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newPlateCapacitorFromKeyBoard.DielectricPermittivity = 
                    double.Parse(Console.ReadLine().Replace('.',','));
                })
            };
            actions.ForEach(SetValue);
            return newPlateCapacitorFromKeyBoard;
        }

        /// <summary>
        /// Ввод данных о цилиндрическом конденсаторе с клавиатуры
        /// </summary>
        /// <returns>Созданный экземпляр класса 
        /// Цилиндрический конденсатор</returns>
        public static CylindricalCapacitor 
            GetNewCylindricalCapacitorFromKeyboard()
        {
            var newCylindricalCapacitorFromKeyBoard = new 
                CylindricalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Height Of Cylinder: ");
                    newCylindricalCapacitorFromKeyBoard.HeightOfCylinder =
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("External Radius Of Cylinder : ");
                    newCylindricalCapacitorFromKeyBoard.
                    ExterRadiusOfCylinder =
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Internal Radius Of Cylinder : ");
                    newCylindricalCapacitorFromKeyBoard.
                    InterRadiusOfCylinder =
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newCylindricalCapacitorFromKeyBoard.
                    DielectricPermittivity =
                    double.Parse(Console.ReadLine().Replace('.',','));
                })
            };
            actions.ForEach(SetValue);
            return newCylindricalCapacitorFromKeyBoard;
        }

        /// <summary>
        /// Ввод данных о сферическом конденсаторе с клавиатуры
        /// </summary>
        /// <returns>Созданный экземпляр класса 
        /// Сферический конденсатор</returns>
        public static SphericalCapacitor
            GetNewSphericalCapacitorFromKeyboard()
        {
            var newShericalCapacitorFromKeyBoard = new
                SphericalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("External Radius Of Sphere : ");
                    newShericalCapacitorFromKeyBoard.
                    ExterRadiusOfSphere =
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Internal Radius Of Sphere : ");
                    newShericalCapacitorFromKeyBoard.
                    InterRadiusOfSphere =
                    double.Parse(Console.ReadLine().Replace('.',','));
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newShericalCapacitorFromKeyBoard.
                    DielectricPermittivity =
                    double.Parse(Console.ReadLine().Replace('.',','));
                })
            };
            actions.ForEach(SetValue);
            return newShericalCapacitorFromKeyBoard;
        }

        /// <summary>
        /// Установить значение свойствам экземпляра класса 
        /// Плоский/Цилиндрический/Сферический конденсатор
        /// </summary>
        /// <param name="action">Делегат Action</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException
                        || exception is FormatException)
                    {
                        Console.WriteLine(exception.Message);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
