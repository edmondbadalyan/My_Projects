using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списочные_Элементы {
    public class Street {
        public string Name { get; }
        public IReadOnlyList<House> Houses { get; }

        public Street (string name, params House[] houses) {
            Name = name;
            Houses = houses;
        }

        public override string ToString () => Name;
    }
}
