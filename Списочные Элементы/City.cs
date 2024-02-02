using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Списочные_Элементы.Form1;

namespace Списочные_Элементы {
    public class City {
        public string Name { get; }
        public IReadOnlyList<Street> Streets { get; }

        public City (string name, params Street[] streets) {
            Name = name;
            Streets = streets;
        }

        public override string ToString () => Name;
    }
}
