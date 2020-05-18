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
        /// Имя человека/существа
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Фамилия человека/существа
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Возраст человека/существа
        /// </summary>
        private int _age;

        #endregion

        #region Свойства класса Человек

        /// <summary>
        /// Имя человека/существа
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
        /// Фамилия человека/существа
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
        /// Возраст человека/существа
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
                        "The age must be between 0 and 900 years.");
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
                    "First/LastName is null or empty!");
            }
            else if (!IsFirstAndLastNameCorrect(value))
            {
                throw new FormatException("First/LastName can only " +
                    "contain Russian or Latin symbols!");
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
            return $"FirstName: {FirstName}\nLastName: {LastName}\n" +
                $"Age: {Age}\nGender: {Gender}";
        }
        #endregion
    }
}
