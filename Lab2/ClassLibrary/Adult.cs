using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс Взрослый веловек
    /// </summary>
    public class Adult : PersonBase
    {
        #region Константы класса Взрослый веловек

        /// <summary>
        /// Минимальный возраст для взрослого человека
        /// </summary>
        public const int MinAgeForAdult = 18;

        /// <summary>
        /// Маскимальный возраст для взрослого человека
        /// </summary>
        public const int MaxAgeForAdult = 122;

        #endregion

        #region Поля класса Взрослый человек

        /// <summary>
        /// Партнер взрослого человека
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Номер паспорта взрослого человека
        /// </summary>
        private string _passportNumber;

        /// <summary>
        /// Серия паспорта взрослого человека
        /// </summary>
        private string _passportSeries;
        #endregion

        #region Свойства класса Взрослый человек

        /// <summary>
        /// Возраст взрослого человека
        /// </summary>
        public override int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < MinAgeForAdult || value > MaxAgeForAdult)
                {
                    throw new ArgumentOutOfRangeException(
                        "The age of adult must be between 18 and " +
                        "122 years.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Состояние брака нового человека
        /// </summary>
        public MarriageState MarriageState { get; set; }

        /// <summary>
        /// Партнер взрослого человека
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The partner " +
                        "of adult cannot have null value!");
                }
                if (MarriageState == MarriageState.Married && 
                    value.MarriageState == MarriageState.Married)
                {
                    _partner = value;
                }
                else
                {
                    throw new ArgumentException("The marriage status " +
                        "of one/two adluts is not 'Married'!");
                }
            }
        }

        public string PassportSeries
        {
            get
            {
                return _passportSeries;
            }
            set
            {
                CheckNumberAndSeriesOfPassport(value, 4);
                _passportSeries = value;
            }
        }

        /// <summary>
        /// Номер паспорта взрослого человека
        /// </summary>
        public string PassportNumber
        {
            get
            {
                return _passportNumber;
            }
            set
            {
                CheckNumberAndSeriesOfPassport(value, 6);
                _passportNumber = value;
            }
        }

        /// <summary>
        /// Место работы взрослого человека
        /// </summary>
        public string PlaceOfWork { get; set; }
        #endregion

        #region Методы класса Взрослый человек

        /// <summary>
        /// Проверка серии/номера паспорта взрослого человека
        /// </summary>
        /// <param name="valueForCheck">Серия/номер паспорта для проверки</param>
        /// <param name="numberOfDigits">Количество цифр в серии/номере паспорта</param>
        private void CheckNumberAndSeriesOfPassport(string valueForCheck,
            int numberOfDigits)
        {
            if (valueForCheck.Length!= numberOfDigits)
            {
                throw new ArgumentException("The series/number of " +
                    "passport can only contain four/six " +
                    "digits respectively!");
            }

            if (!int.TryParse(valueForCheck, out int result))
            {
                throw new FormatException("The series/number of passport " +
                    "can only contain numbers and not other symbols!");
            }
        }

        /// <summary>
        /// Получить информацию о взрослом человеке
        /// </summary>
        /// <returns>Информация о взрослом человеке</returns>
        public override string GetPersonInfo()
        {
            var infoAboutAdult = GetPersonBaseInfo() + $"\nPassport" +
                $" series: {PassportSeries}\nPassportNumber:" +
                $" {PassportNumber}\nMarriageState: {MarriageState}";

            if (MarriageState == MarriageState.Married)
            {
                infoAboutAdult += $"\nPartner: {Partner.FirstName} " +
                    $"{Partner.LastName}";
            }

            infoAboutAdult += "\nPlace of work: ";

            if (string.IsNullOrEmpty(PlaceOfWork))
            {
                infoAboutAdult += "Umemployed";
            }
            else
            {
                infoAboutAdult += PlaceOfWork;
            }

            return infoAboutAdult;
        }

        #endregion
    }
}
