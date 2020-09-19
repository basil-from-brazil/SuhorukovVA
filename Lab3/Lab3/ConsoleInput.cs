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
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Gap Between PLates: ");
                    newPlateCapacitorFromKeyBoard.GapBetweenPlates =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newPlateCapacitorFromKeyBoard.DielectricPermittivity =
                        ReadFromConsoleAndParse();
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
            var newCylindricalCapacitorFromKeyBoard = 
                new CylindricalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Height Of Cylinder: ");
                    newCylindricalCapacitorFromKeyBoard.HeightOfCylinder =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("External Radius Of Cylinder : ");
                    newCylindricalCapacitorFromKeyBoard.
                        ExterRadiusOfCylinder =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Internal Radius Of Cylinder : ");
                    newCylindricalCapacitorFromKeyBoard.
                        InterRadiusOfCylinder =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newCylindricalCapacitorFromKeyBoard.
                        DielectricPermittivity =
                        ReadFromConsoleAndParse();
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
            var newShericalCapacitorFromKeyBoard = 
                new SphericalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("External Radius Of Sphere : ");
                    newShericalCapacitorFromKeyBoard.
                        ExterRadiusOfSphere =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Internal Radius Of Sphere : ");
                    newShericalCapacitorFromKeyBoard.
                        InterRadiusOfSphere =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Dielectric Permittivity: ");
                    newShericalCapacitorFromKeyBoard.
                        DielectricPermittivity =
                        ReadFromConsoleAndParse();
                })
            };
            actions.ForEach(SetValue);
            return newShericalCapacitorFromKeyBoard;
        }

        /// <summary>
        /// Получить пользовательский ввод и преобразовать в double
        /// </summary>
        public static double ReadFromConsoleAndParse()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
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
