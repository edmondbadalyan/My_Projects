

using System;
using Struct_Enum;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите расу (0 - Орк, 1 - Эльф, 2 - Человек, 3 - Гном, 4 - Тролль, 5 - Гоблин):");
        int raceChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите роль (0 - Воин, 1 - Маг, 2 - Священник, 3 - Разбойник, 4 - Охотник, 5 - Друид):");
        int roleChoice = int.Parse(Console.ReadLine());

        if (Enum.IsDefined(typeof(Race), raceChoice) && Enum.IsDefined(typeof(Role), roleChoice))
        {
           

            Character playerCharacter = new Character((Race)raceChoice, (Role)roleChoice);
            


            Console.WriteLine(playerCharacter);
        }
        else
        {
            Console.WriteLine("Неправильный выбор расы или роли.");
        }
    }
}
