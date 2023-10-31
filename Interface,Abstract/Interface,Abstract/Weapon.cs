using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
{
    internal class Weapon : Item, IUsable
    {
        
            public Weapon(string name) : base(name) { }

            public void Use()
            {
                Console.WriteLine($"Вы вооружились {Name}");
            }
        


    }
}
