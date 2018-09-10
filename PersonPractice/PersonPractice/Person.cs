using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPractice
{
    class Person
    {
            private string _firstname;
            private string _lastname;

        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public string GetFullName()
        {
            return $"{_firstname} {_lastname}";
        }
          
    }
}
