using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Lab2
{
    /// <summary>
    /// Класс для тестирования библиотеки классов ClassLibrary
    /// </summary>
    public class LabTest
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the programme...");
            Console.ReadKey();

            Console.WriteLine("Generating seven random people...\n");
            Console.ReadKey();

            var people = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                people.AddPerson(RandomPerson.GenerateRandomPerson());
            }

            Console.WriteLine("Random generated list:\n");

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people.GetPersonByIndex(i).GetPersonInfo());
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Write("The forth person in list is ");

            if (people.GetPersonByIndex(3) is Adult adult)
            {
                Console.Write("adult person.");
                Console.WriteLine(adult.GetJobPromotion());
            }
            else if (people.GetPersonByIndex(3) is Child child)
            {
                Console.Write("child person.");
                Console.WriteLine(child.TryBuyingAlcohol());
            }

            Console.WriteLine("\nThis is the end of Lab 3...");
            Console.ReadKey();
        }
    }
}
