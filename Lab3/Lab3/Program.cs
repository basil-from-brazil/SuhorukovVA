using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Lab3
{
    /// <summary>
    /// Класс для тестирования библиотеки классов Model
    /// </summary>
    public class ConsoleLoader
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the programme...\n");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Please, select an action:");
                Console.WriteLine("1 - Calculate the capacitance " +
                    "of plate capacitor");
                Console.WriteLine("2 - Calculate the capacitance " +
                    "of cylindrical capacitor");
                Console.WriteLine("3 - Calculte the capacitance " +
                    "of spherical capacitor");
                Console.WriteLine("4 - Exit the programme...");
                var menuKey = Console.ReadLine();
                switch (menuKey)
                {
                    case "1":
                    {
                        GetCapacitanceInfo(ConsoleInput.
                            GetNewPlateCapacitorFromKeyboard());
                        break;
                    }
                    case "2":
                    {
                        GetCapacitanceInfo(ConsoleInput.
                            GetNewCylindricalCapacitorFromKeyboard());
                        break;
                    }
                    case "3":
                    {
                        GetCapacitanceInfo(ConsoleInput.
                            GetNewSphericalCapacitorFromKeyboard());
                        break;
                    }
                    case "4":
                    {
                        Environment.Exit(0);
                        break;
                    }
                    default:
                    {
                            Console.WriteLine("There is no such action! " +
                                "Please, try again!\n");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Вывести ифномарцию о емкости конденсатора на консоль
        /// </summary>
        /// <param name="capacitor">Экземпляр класса Конденсатор</param>
        public static void GetCapacitanceInfo(CapacitorBase capacitor)
        {
            Console.WriteLine($"The capacitance is equal " +
                $"to {capacitor.Capacity} F\n");
        }
    }
}
