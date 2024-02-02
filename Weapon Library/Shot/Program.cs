using Weapon_Library;


namespace Shot
{

    public class Program
    {
        public static void Main(string[] args)
        {
            IWeapon weapon = Weapon.Create("Shotgun");
            int target = 100;
            int count=0;
            Console.WriteLine("Weapon Name: " + weapon.Name);
            Console.WriteLine("Damage: " + weapon.Damage);
            Console.WriteLine("Fire Interval: " + weapon.FireRate);

            for (int i = 0; i < target; i++)
            {
                target = target - weapon.Damage;
                Console.WriteLine($"{target}");
                count++;
                
            }
            Console.WriteLine($"Потребовалось выстрелов {count}");


        }

    }


}