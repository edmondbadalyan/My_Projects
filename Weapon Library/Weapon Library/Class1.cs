namespace Weapon_Library
{
    public interface IWeapon
    {
        int Damage { get; }
        TimeSpan FireRate { get; }
        string Name { get; }

    }
    internal class Shotgun : IWeapon
    {
        public int Damage { get; } = 10;
        public TimeSpan FireRate { get; } = TimeSpan.FromSeconds(3);
        public string Name { get; } = "Shotgun";
    }
    internal class Rifle : IWeapon
    {
        public int Damage { get; } = 7;
        public TimeSpan FireRate { get; } = TimeSpan.FromSeconds(2);
        public string Name { get;  } = "Rifle";
    }

    public static class Weapon
    {
        public static IWeapon Create(string weaponType)
        {
            
            if (weaponType == "Shotgun")
            {
                return new Shotgun();
            }
            
            else if (weaponType == "Rifle")
            {
                return new Rifle();
            }
            else
            {
                throw new ArgumentException("Invalid weapon type");
            }
        }
    }



}
