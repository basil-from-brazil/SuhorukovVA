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
    /// Класс Члеловек
    /// </summary>
    public abstract class PersonBase
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
        protected int _age;

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
        public virtual int Age { get; set; }
        
        /// <summary>
        /// Пол человека
        /// </summary>
        public Genders Gender { get; set; }

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
        /// Абстрактный метод получения информации об экземпляре класса 
        /// Человек
        /// </summary>
        /// <returns>Информацию об экземпляре класса человек</returns>
        public abstract string GetPersonInfo();

        /// <summary>
        /// Метод получения основной информации об экземпляре класса 
        /// Человек
        /// </summary>
        /// <returns>Основная информацию об экземпляре класса 
        /// Человек</returns>
        protected string GetPersonBaseInfo()
        {
            return $"FirstName: {FirstName}\n" +
                   $"LastName: {LastName}\n" +
                   $"Age: {Age}\n" +
                   $"Gender: {Gender}";
        }
        
        #endregion
    }
}

