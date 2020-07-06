using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс, реализующий исключение при отсутствии объекта Человек в списке
    /// </summary>
    public class PersonNotFoundException : Exception
    {
        public PersonNotFoundException(string message) : base(message) { }
    }
}
