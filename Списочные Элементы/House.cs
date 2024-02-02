using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списочные_Элементы {
    public class House {
        public int Number { get; }

        public House (int number) {
            Number = number;
        }

        public override string ToString () => Number.ToString ();
    }
}
