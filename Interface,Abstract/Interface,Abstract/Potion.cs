using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
{
    internal class Potion : Item, IUsable
    {

        public Potion(string name) : base(name) { }

        public void Use()
        {
            Console.WriteLine($"Вы выпили {Name} и восполнили жизни");
        }


    }
}
