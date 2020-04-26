using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Lab1
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

            Console.WriteLine("Creating 2 lists of people... Each list contains 3 people.");

            var jedi = new PersonList();
            var sith = new PersonList();

            var peopleForFirstList = new Person[]
            {
                new Person("Luke","Skywalker",53,Genders.Male),
                new Person("Obi-Wan","Kenobi",57,Genders.Male),
                new Person("Rey","Skywalker",20,Genders.Female)
            };

            var peopleForSecondList = new Person[]
            {
                new Person("Darth","Vader",45,Genders.Male),
                new Person("Darth","Sidious",119,Genders.Male),
                new Person("Kylo","Ren",30,Genders.Male)

            };

            jedi.AddSeveralPeople(peopleForFirstList);
            sith.AddSeveralPeople(peopleForSecondList);

            Console.WriteLine("2 lists of people have been created!");
            Console.ReadKey();
        }
    }
}
