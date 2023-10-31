using System;
using System.Collections.Generic;

using Interface_Abstract;

class Program
{
    static void Main()
    {
        // Создаем предметы и добавляем их в инвентарь игрока
        Item[] inventory = new Item[]
        {
            new Weapon("Мечом"),
            new Armor("Тяжёлые доспехи"),
            new Potion("Зелье здоровья")
        };

        // Игрок выбирает предмет для использования
        Console.WriteLine("Какой предмет использовать:");
        for (int i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine($"{(1 + i)}. {inventory[i].Name}");
        }

        int choice = int.Parse( Console.ReadLine() );
        Console.WriteLine();

        if (choice >= 1 && choice <= inventory.Length)
        {
            // Индекс в массиве выбранного предмета
            int itemIndex = choice - 1;
            Item selectedItem = inventory[itemIndex];

            // Используем выбранный предмет
            if (selectedItem is IUsable usableItem)
            {
                usableItem.Use();
            }
            
        }
        else
        {
            Console.WriteLine("Некорректный выбор.");
        }
       

    }
}
