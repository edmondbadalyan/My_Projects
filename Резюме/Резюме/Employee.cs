using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Резюме
{
    internal class Employee
    {

        public string FullName { get;  }
        public DateTime Birthday { get;  }

        public Employee(string fullName, DateTime birthday)
        {
            FullName = fullName;
            Birthday = birthday;
        }

        public override string ToString() => $"{FullName} {Birthday}";
    }
}
