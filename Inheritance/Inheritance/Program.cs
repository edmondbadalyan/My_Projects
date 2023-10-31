//1.Создайте базовый абстрактный класс Оружие и подклассы: пистолет, ружьё, снайперская винтовка, автомат.

//У всякого оружия есть числовые характеристики:

//1) damage: сколько единиц урона наносит за выстрел
//2) interval: интервал между выстрелами в секундах

//Используйте виртуальные методы, свойства, наследование.


//2. В новом классе напишите функцию «Испытательный стенд». Ей дают экземпляр оружия — любого: она заранее не знает, что тестирует.

//Функция выполняет симуляцию боя, расстреливая мишень. У мишени изначально 100 единиц здоровья. Каждый выстрел снимает ей количество здоровья в зависимости от оружия, печатает выстрел на экран, после чего происходит задержка до следующего выстрела. Расстрел продолжается в цикле, пока мишень не будет повержена.

//Для задержки используйте функцию Thread.Sleep. Например, Thread.Sleep (2000) ставит программу на паузу в течение 2000 миллисекунд = 2 секунд.

//По окончании симуляции функция печатает отчёт:

//• Оружие: пистолет
//• Для убийства мишени понадобилось сделать 4 выстрела
//• Урон в секунду (damage per second, dps) составил 25 жизни/сек

//С помощью испытательного стенда протестируйте всё оружие.

public abstract class Weapon
{
    public int Damage { get; }
    public float Interval { get; }

    protected Weapon(int damage, float interval)
    {
        Damage = damage;
        Interval = interval;
    }

    public virtual void Fire() {

        Console.WriteLine("Shot from a basic weapon");

    }

}

public class Gun : Weapon
{
    
    public Gun() : base(20, 0.5f) { }
    public override void Fire()
    {
        Console.WriteLine("Shot from a Gun");

    }

}

public class Shotgun : Weapon
{

    public Shotgun() : base(50, 2.0f) { }
    
    public override void Fire()
    {
        Console.WriteLine("Shot from a Shotgun");

    }
}

public class SniperRifle : Weapon
{
  
    public SniperRifle() : base(100, 4.0f) { }


    public override void Fire()
    {
        Console.WriteLine("Shot from a SniperRifle");

    }
}

public class MachineGun : Weapon
{

    public MachineGun() : base(30, 0.2f) { }
    public override void Fire()
    {
        Console.WriteLine("Shot from a MachineGun");

    }
}

public class Program
{

    public static void Main(string[] strings) {


        Weapon[] weapon = {
            new Gun(),
            new MachineGun(),
            new Shotgun(),
            new SniperRifle(),
        };
        Random random = new Random();
        Weapon randomWeapon = weapon[random.Next(weapon.Length)];

        
        TestBench(randomWeapon);

        void TestBench(Weapon weapon)
        {
            Console.WriteLine("Weapon: " + weapon.GetType().Name);

            int target = 100;
            int shots = 0;

            DateTime StartSimulation = DateTime.Now;


            while (target >= 0)
            {
                weapon.Fire();

                Thread.Sleep(2000);

                target = target - weapon.Damage;

                shots++;


            }

            DateTime EndSimulation = DateTime.Now;
            TimeSpan Duration = StartSimulation - EndSimulation;

            double dps = 100.0 / Duration.TotalSeconds;
            Console.WriteLine("To kill the test bench you need " + shots + " shots");
            Console.WriteLine("Damage per second " + dps.ToString("0.00") + " жизни/сек");

        }
    }


  





}

    


