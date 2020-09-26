using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс Ребенок
    /// </summary>
    public class Child : PersonBase
    {
        #region Константы класса Ребенок

        /// <summary>
        /// Минимальный возраст для ребенка
        /// </summary>
        public const int MINAGE = 0;

        /// <summary>
        /// Маскимальный возраст для ребенка
        /// </summary>
        public const int MAXAGE = 17;

        #endregion

        #region Поля класса Ребенок
                
        /// <summary>
        /// Название детского сада или школы ребенка
        /// </summary>
        private string _kindergartenOrSchool;

        #endregion

        #region Свойства класса Ребенок

        /// <summary>
        /// Возраст ребенка
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException(
                        "The age of child must be between 0 and " +
                        "17 years.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Папа ребенка
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Мама ребенка
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Название детского сада или школы ребенка
        /// </summary>
        public string KindergartenOrSchool
        {
            get
            {
                return _kindergartenOrSchool;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The kindergarten/" +
                        "school cannot have null/empty value!");
                }
                _kindergartenOrSchool = value;
            }
        }
        #endregion

        #region Методы класса Ребенок

        /// <summary>
        /// Получить информацию о ребенке
        /// </summary>
        /// <returns>Информация о ребенке</returns>
        public override string GetPersonInfo()
        {
            var infoAboutChild = GetPersonBaseInfo() + 
                $"\nKindergarten/school: {KindergartenOrSchool}";

            if (Mother != null)
            {
                infoAboutChild += $"\nMother: {Mother.GetPersonInfo()}";
            }

            if (Father != null)
            {
                infoAboutChild += $"\nFather: {Father.GetPersonInfo()}";
            }

            return infoAboutChild;
        }

        /// <summary>
        /// Попытаться купить алкоголь
        /// </summary>
        /// <returns>Невозможность купить алкоголь</returns>
        public string TryBuyingAlcohol()
        {
            return $"\n{GetPersonBaseShortInfo()} cannot buy alcohol! " +
                $"He is still under 18!";
        }

        #endregion
    }
}
