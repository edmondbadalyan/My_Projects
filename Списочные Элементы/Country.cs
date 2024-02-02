using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Списочные_Элементы.Form1;

namespace Списочные_Элементы {
    public class Country {
        public string Name { get; }
        public IReadOnlyList<City> Cities { get; }

        public Country (string name, params City[] cities) {
            Name = name;
            Cities = cities;
        }

        public override string ToString () => Name;
    }
}
