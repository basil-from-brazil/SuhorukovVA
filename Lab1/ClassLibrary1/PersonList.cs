using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс Список людей
    /// </summary>
    public class PersonList
    {

        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _people;

        /// <summary>
        /// Конструктор по умолчанию, создает пустой список
        /// </summary>
        public PersonList()
        {
            _people = new Person[0];
        }

        /// <summary>
        /// Количество людей в списке
        /// </summary>
        public int Length
        {
            get
            {
                return _people.Length;
            }
        }

        #region Методы класса Список людей

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Экземпляр класса Человек</param>
        public void AddPerson (Person person)
        {
            var currentPeople = _people;
            _people = new Person[currentPeople.Length + 1];
            for (int i = 0; i < currentPeople.Length; i++)
            {
                _people[i] = currentPeople[i];
            }
            _people[currentPeople.Length] = person;
        }

        /// <summary>
        /// Удаление человека из списка
        /// </summary>
        /// <param name="person">Экземпляр класса Человек</param>
        public void DeletePerson(Person person)
        {
            DeletePersonByIndex(GetPersonIndex(person));
        }

        /// <summary>
        /// Получение индекса объекта Человек при его наличии в списке
        /// </summary>
        /// <param name="person">Экземпляр класса Человек</param>
        /// <returns>Индекс экземпляра класса Человек</returns>
        public int GetPersonIndex(Person person)
        {
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i] == person)
                {
                    return i;
                }
            }
            throw new PersonNotFoundException("This person does not exist " +
                "in this list. Please try again.");
        }
        
        /// <summary>
        /// Получение объекта класса Человек по его индексу
        /// </summary>
        /// <param name="indexOfPerson">Индекс объекта класса Человек</param>
        /// <returns>Объект класса Человек</returns>
        public Person GetPersonByIndex(int indexOfPerson)
        {
            //TODO: Дубль (исправил, добавил метод IsIndexOfPersonCorrect)
            CheckIndexOfPerson(indexOfPerson);
            return _people[indexOfPerson];
        }

        /// <summary>
        /// Удаление объекта класса Человек по его индексу
        /// </summary>
        /// <param name="indexOfPerson">Индекс экземпляра класса 
        /// Человек</param>
        public void DeletePersonByIndex(int indexOfPerson)
        {
            //TODO: Дубль (исправил, добавил метод CheckIndexOfPerson)
            CheckIndexOfPerson(indexOfPerson);
            var currentPeople = _people;
            var newIndex = 0;
            _people = new Person[currentPeople.Length - 1];
            for (int i = 0; i < currentPeople.Length; i++)
            {
                if (i!=indexOfPerson)
                {
                    _people[newIndex] = currentPeople[i];
                    newIndex = newIndex + 1;
                }
            }
            
        }

        /// <summary>
        /// Проверка корректности индекса экземпляра класса Человек
        /// </summary>
        /// <param name="indexOfPerson">Индекс экземпляра класса 
        /// Человек</param>
        private void CheckIndexOfPerson(int indexOfPerson)
        {
            if (indexOfPerson < 0 || indexOfPerson > _people.Length - 1)
            {
                throw new IndexOutOfRangeException("You entered " +
                    "the wrong index. Please try again");
            }
        }

        /// <summary>
        /// Очитска списка людей
        /// </summary>
        public void Clear()
        {
            _people = new Person[0];
        }

        #endregion
    }
}
