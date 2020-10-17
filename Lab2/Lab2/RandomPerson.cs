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
            if (person.Gender == Genders.Male)
            {
                var allMaleNames = Properties.Resource.MaleNames.Split('\n');
                var randomElementMales = allMaleNames[_random.Next(0, allMaleNames.Length)];
                person.FirstName = randomElementMales.Substring(0, randomElementMales.Length - 1);
            }
            else
            {
                var allFemaleNames = Properties.Resource.FemaleNames.Split('\n');
                var randomElementFemales = allFemaleNames[_random.Next(0, allFemaleNames.Length)];
                person.FirstName = randomElementFemales.Substring(0, randomElementFemales.Length - 1);
            }
            var allLastNames = Properties.Resource.LastNames.Split('\n');
            var randomElement = allLastNames[_random.Next(0, allLastNames.Length)];
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
        /// <param name="isGenderSet">Генерируется ли пол случайным образом</param>
        /// <returns>Сгенерированный взрослый человек</returns>
        public static Adult GenerateRandomAdult(bool forMarriage = false, Adult partner = null, 
            bool isGenderSet = false, bool isAdultAParent = false, 
            bool isAdultAMother = false)
        {
            var randomAdult = new Adult();
            if (!isGenderSet)
            {
                randomAdult.Gender = (Genders)_random.Next(0, 2);
            }
            else
            {
                if (isAdultAParent)
                {
                    randomAdult.Gender = isAdultAMother 
                        ? Genders.Female
                        : Genders.Male;                    
                }
            }
            if (!forMarriage)
            {
                randomAdult.MarriageState = 
                    (MarriageState)_random.Next(0, 4);

                if (randomAdult.MarriageState == MarriageState.Married)
                {
                    randomAdult.Partner =
                        GenerateRandomAdult(true, randomAdult, true);
                }
            }
            else
            {
                randomAdult.MarriageState = MarriageState.Married;
                randomAdult.Partner = partner;
                randomAdult.Gender = partner.Gender == Genders.Male 
                        ? Genders.Female
                        : Genders.Male;    
            }
            randomAdult.Age = _random.Next(Adult.MINAGE, Adult.MAXAGE + 1);
            GenerateGeneralPersonInfo(randomAdult);
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
            randomChild.Gender = (Genders)_random.Next(0, 2);
            GenerateGeneralPersonInfo(randomChild);
            randomChild.Age = _random.Next(Child.MINAGE, Child.MAXAGE + 1);

            bool haveMother = Convert.ToBoolean(_random.Next(0, 2));
            if (haveMother)
            {
                randomChild.Mother = GenerateRandomAdult(isGenderSet: true, 
                    isAdultAParent : true, isAdultAMother : true);
            }

            bool haveFather = Convert.ToBoolean(_random.Next(0, 2));
            if (haveFather)
            {
                randomChild.Father = GenerateRandomAdult(isGenderSet : true, isAdultAParent: true);
            }
            
            randomChild.KindergartenOrSchool = randomChild.Age < 7
                ? GetRandomKindergartenOrSchool(Properties.Resource.Kindergartens)
                : GetRandomKindergartenOrSchool(Properties.Resource.Schools);

            return randomChild;
        }

        ///
        private static string GetRandomKindergartenOrSchool(string kinderGartenOrSchool)
        {
            var allKindergartenOrSchoolNames = kinderGartenOrSchool.Split('\n');                  
            return allKindergartenOrSchoolNames
                [_random.Next(0, allKindergartenOrSchoolNames.Length)];
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
