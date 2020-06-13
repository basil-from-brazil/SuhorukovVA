using System;
using System.Collections.Generic;
using System.Globalization;
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

            Console.WriteLine("Creating 2 lists of people... " +
                "Each list contains 3 people.");

            var jedi = new PersonList();
            var sith = new PersonList();

            var peopleForFirstList = new Person[]
            {
                new Person("Luke", "Skywalker", 53, Genders.Male),
                new Person("Obi-Wan", "Kenobi", 57, Genders.Male),
                new Person("Rey", "Skywalker", 20, Genders.Female)
            };

            var peopleForSecondList = new Person[]
            {
                new Person("Darth", "Vader", 45, Genders.Male),
                new Person("Darth", "Sidious", 119, Genders.Male),
                new Person("Kylo", "Ren", 30, Genders.Male)
            };

            //TODO: Добавить пользовательский ввод
            //TODO: Статическая генерация персоны

            jedi.AddSeveralPeople(peopleForFirstList);
            sith.AddSeveralPeople(peopleForSecondList);

            Console.WriteLine("2 lists of people have been created!");
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Adding a new jedi to the first list...");
            var newJedi = new Person("Ahsoka", "Tano", 16, Genders.Female);
            jedi.AddPerson(newJedi);
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Copying the 2nd person from the 1st list " +
                "to the end of 2nd list...");
            sith.AddPerson(jedi.GetPersonByIndex(1));
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Deleting the 2nd person from " +
                "the 1st list...");
            jedi.DeletePersonByIndex(1);
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Clearing the 2nd list...");
            sith.Clear();
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Adding to the 2nd list " +
                "a sith from keyboard...");
            sith.AddPerson(GetNewPersonFromKeyBoard());
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("Adding to the 2nd list a random sith...");
            sith.AddPerson(Person.GetRandomSith());
            DisplayListsOfPeople(jedi, sith);

            Console.WriteLine("This is the end of Lab 1\n" +
                "May the Force be with you, young padawan!");
            Console.ReadKey();
        }

        /// <summary>
        /// Отображение списков людей в консоли
        /// </summary>
        /// <param name="firstListOfPeople">Первый список людей</param>
        /// <param name="secondListOfPeople">Второй список людей</param>
        public static void DisplayListsOfPeople(PersonList firstListOfPeople,
            PersonList secondListOfPeople)
        {
            Console.ReadKey();
            var listsOfPeople = new PersonList[]
            {
               firstListOfPeople,
               secondListOfPeople
            };

            for (int i = 0; i < listsOfPeople.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"List Number {i + 1}");
                Console.WriteLine();

                for (int j = 0; j < listsOfPeople[i].Length; j++)
                {
                    Console.WriteLine(listsOfPeople[i].GetPersonByIndex(j).
                        GetPersonInfo());
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Ввод данных о человеке/существе с клавиатуры
        /// </summary>
        /// <returns>Созданный экземпляр класса Человек</returns>
        public static Person GetNewPersonFromKeyBoard()
        {
            var newPersonFromKeyBoard = new Person();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("FirstName: ");
                    newPersonFromKeyBoard.FirstName = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("LastName: ");
                    newPersonFromKeyBoard.LastName = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Age: ");
                    newPersonFromKeyBoard.Age = int.Parse(Console.ReadLine());
                }),
                new Action(() =>
                {
                    Console.Write("Gender (Male/Female): ");
                    var genderFromKeyBoard = Console.ReadLine();
                    genderFromKeyBoard = CultureInfo.InvariantCulture.
                    TextInfo.ToTitleCase(genderFromKeyBoard.ToLower());
                    newPersonFromKeyBoard.Gender = (Genders)Enum.Parse
                    (typeof(Genders),genderFromKeyBoard);

                })
            };
            actions.ForEach(SetValue);
            return newPersonFromKeyBoard;
        }

        /// <summary>
        /// Установить значение свойствам экземпляра класса Человек
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
