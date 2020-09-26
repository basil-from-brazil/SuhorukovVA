using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, возвращающий случайного ребенка/взрослого человека
    /// </summary>
    public static class RandomPerson
    {
        #region Поля класса Случайный человек

        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        #endregion

        #region Методы класса Случайный человек

        /// <summary>
        /// Сгенерировать базовую информацию об экземпляре класса Человек
        /// </summary>
        /// <param name="person">Базовая информация 
        /// об экземпляре класса Человек</param>
        public static void GenerateGeneralPersonInfo(PersonBase person)
        {
            var allFirstNames = Properties.Resource.FirstNamesAndGenders.Split('\n');
            var randomElement = allFirstNames[_random.Next(0, allFirstNames.Length)];

            var firstNameAndGender = randomElement.Split('\t');
            person.FirstName = firstNameAndGender[0];
            person.Gender = (Genders)Enum.Parse(typeof(Genders), firstNameAndGender[1]);

            var allLastNames = Properties.Resource.LastNames.Split('\n');
            randomElement = allLastNames[_random.Next(0, allLastNames.Length)];
            person.LastName = randomElement.Substring(0, randomElement.Length - 1);
        }

        /// <summary>
        /// Заполнить нулями недостающие цифры в серии/номере паспорта
        /// </summary>
        /// <param name="passportData">Серия/номер паспорта</param>
        /// <param name="requiredNumbersAmount">Требуемое число цифр 
        /// в серии/номера паспорта</param>
        /// <returns>Серия/номер паспорта с заполненными нулями</returns>
        private static string FillPassportNumberWithZeros(string passportData, int requiredNumbersAmount)
        {
            if (passportData.Length < requiredNumbersAmount)
            {
                var zerosAmount = requiredNumbersAmount - passportData.Length;
                for (int i=0; i < zerosAmount; i++)
                {
                    passportData = "0" + passportData;
                }
            }
            return passportData;
            
        }

        /// <summary>
        /// Сгенерировать серию и номер паспорта
        /// </summary>
        /// <param name="isPassportNumber">Генерировать ли номер паспорта</param>
        /// <returns>Серия и номер паспорта</returns>
        private static string GeneratePassportData(bool isPassportNumber)
        {
            if (isPassportNumber)
            {
                return FillPassportNumberWithZeros(_random.Next(0, 1000000).ToString(), 6);
            }
            else
            {
                return FillPassportNumberWithZeros(_random.Next(0, 10000).ToString(), 4);
            }
        }

        /// <summary>
        /// Сгенерировать случайного взрослого
        /// </summary>
        /// <param name="forMarriage">Генерация партнера для человека,
        /// состоящего в браке</param>
        /// <param name="partner">Партнер взрослого человека</param>
        /// <returns>Сгенерированный взрослый человек</returns>
        public static Adult GenerateRandomAdult(bool forMarriage = false, Adult partner = null, 
            //bool isSetGender = false, //Genders gender = Genders.Male)
        {
            var randomAdult = new Adult();

            GenerateGeneralPersonInfo(randomAdult);

            randomAdult.Age = _random.Next(Adult.MINAGE, Adult.MAXAGE + 1);

            if (!forMarriage)
            {
                randomAdult.MarriageState =
                    (MarriageState)_random.Next(0, 4);

                if (randomAdult.MarriageState == MarriageState.Married)
                {
                    randomAdult.Partner =
                        GenerateRandomAdult(true, randomAdult);
                }
            }
            else
            {
                randomAdult.MarriageState = MarriageState.Married;
                randomAdult.Partner = partner;
            }

            var allCompanyNames =
                Properties.Resource.CompaniesNames.Split('\n');
            randomAdult.PlaceOfWork =
                allCompanyNames[_random.Next(0, allCompanyNames.Length)];

            randomAdult.PassportNumber = GeneratePassportData(true);
            randomAdult.PassportSeries = GeneratePassportData(false);

            return randomAdult;
        }

        /// <summary>
        /// Сгенерировать нового ребенка
        /// </summary>
        /// <returns>Сгенерированный ребенок</returns>
        public static Child GenerateRandomChild()
        {
            var randomChild = new Child();

            GenerateGeneralPersonInfo(randomChild);
            randomChild.Age = _random.Next(Child.MINAGE, Child.MAXAGE);

            bool haveMother = Convert.ToBoolean(_random.Next(0, 2));
            if (haveMother)
            {
                randomChild.Mother = GenerateRandomAdult();
                while (randomChild.Mother.Gender == Genders.Male)
                {
                    randomChild.Mother = GenerateRandomAdult();
                }
            }

            bool haveFather = Convert.ToBoolean(_random.Next(0, 2));
            if (haveFather)
            {
                randomChild.Father = GenerateRandomAdult();
                while (randomChild.Father.Gender == Genders.Female)
                {
                    randomChild.Father = GenerateRandomAdult();
                }
            }
            if (randomChild.Age < 7)
            {
                var allKindergardensNames =
                Properties.Resource.Kindergartens.Split('\n');
                randomChild.KindergartenOrSchool =
                    allKindergardensNames
                    [_random.Next(0, allKindergardensNames.Length)];
            }
            else
            {
                var allSchoolsNames =
                Properties.Resource.Schools.Split('\n');
                randomChild.KindergartenOrSchool =
                    allSchoolsNames
                    [_random.Next(0, allSchoolsNames.Length)];
            }

            return randomChild;
        }

        /// <summary>
        /// Сгенерировать случайного человека
        /// </summary>
        /// <returns>Сгенерированный человек</returns>
        public static PersonBase GenerateRandomPerson()
        {
            if (_random.Next(0, 2) != 0)
            {
                return GenerateRandomAdult();
            }
            else
            {
                return GenerateRandomChild();
            }
        }
        #endregion
    }
}
