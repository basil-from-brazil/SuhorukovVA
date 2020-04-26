using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

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
                _firstName = ConvertToRightRegister(value);
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
                _lastName = ConvertToRightRegister(value);
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
                //900 лет - возраст Йоды
                if (value <0 || value > 900)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 900.");
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
        public Person() : this("Vasya","Petechkin",18,Genders.Male)
        {
            //TODO: Дублируется присваивание, можно убрать дублирование
            //TODO: через конструктор, который ниже
            //исправил с использованием слова this
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
            else if (!IsFirstAndLastNameCorrect(value))
            {
                throw new FormatException($"{nameof(value)} can only " +
                    $"contain Russian or Latin symbols!");
            }
        }

        /// <summary>
        /// Проверка имени/фамилии Человека на соответствие шаблону
        /// </summary>
        /// <param name="value">Фамилия или имя для проверки</param>
        /// <returns>Булевое верно/неверно в зависимости от 
        /// результатов проверки</returns>
        private bool IsFirstAndLastNameCorrect(string value)
        {
            var regex = new Regex("^([A-Za-z]|[А-Яа-я])+(((-)?([A-Za-z]|" +
                "[А-Яа-я])+))?$");
            if (!regex.IsMatch(value))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Преобразование букв фамилии/имени в правильный регистр: 
        /// первая буква заглавная, остальные прописные 
        /// </summary>
        /// <param name="value">Фамилия или имя для преобразования</param>
        /// <returns>Фамилия или имя, преобрахованные 
        /// в правильный регистр</returns>
        private string ConvertToRightRegister(string value)
        {
            return CultureInfo.InvariantCulture.TextInfo.
                ToTitleCase(value.ToLower());
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
