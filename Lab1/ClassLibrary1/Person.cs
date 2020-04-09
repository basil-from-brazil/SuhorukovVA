using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс Человек
    /// </summary>
    public class Person
    {
        #region Поля класса Человек

        /// <summary>
        /// Имя человека
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Фамилия человека
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Возраст человека
        /// </summary>
        private int _age;

        #endregion

        #region Свойства класса Человек

        /// <summary>
        /// Имя человека
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                CheckFirstAndLastName(value);
                _firstName = value;
            }
        }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                CheckFirstAndLastName(value);
                _lastName = value;
            }
        }

        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <0 || value > 122)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 122.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Пол человека
        /// </summary>
        public Genders Gender { get; set; }

        #endregion

        #region Конструкторы класса Человека

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
            //TODO: Дублируется присваивание, можно убрать дублирование
            //TODO: через конструктор, который ниже
            FirstName = "Vasya";
            LastName = "Petechkin";
            Age = 18;
            Gender = Genders.Male;
        }

        /// <summary>
        /// Констукрутор класса
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        public Person(string firstName, string lastName, int age,
            Genders gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        #endregion

        #region Методы класса Человек

        /// <summary>
        /// Проверка имени и фамилии, присваемых экземпляру класса Человек
        /// </summary>
        /// <param name="value">Фамилия или имя для проверки</param>
        private void CheckFirstAndLastName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    $"{nameof(value)} is null or empty!");
            }
        }

        /// <summary>
        /// Получить информацию об экземпляре класса Человек
        /// </summary>
        /// <returns>Фамилия, имя, возраст, пол объекта Человек</returns>
        public string GetPersonInfo()
        {
            return $"Имя: {FirstName}\n Фамилия: {LastName}\n " +
                $"Возраст: {Age}\n Пол: {Gender}";
        }
        #endregion
    }
}
