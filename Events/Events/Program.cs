using System;
using System.Collections.Generic;

public class SocialNetwork
{
    public event Action<string, string, DateTime> LikeEvent;
    public event Action<DateTime, string> NewsEvent;
    public void GenerateLikes()
    {
        Random random = new Random();
        string[] users = { "Edmond", "David", "Anna", "Robert", "Vincent", "Henry", "Sokrat", "Lilu", "Rita", "Nonna" };

        for (int i = 0; i < 10; i++)
        {
            string liker = users[random.Next(users.Length)];
            string liked = users[random.Next(users.Length)];
            DateTime timestamp = DateTime.Now;

            LikeEvent?.Invoke(liker, liked, timestamp);
            

            Task.Delay(0000).Wait();
        }
    }

    public void GenerateNews()
    {
        Random random = new Random();
        string[] users = { "Vivian", "Lee", "Anri" };
        foreach (string user in users)
        {
            string subscriber = users[random.Next(users.Length)];
           //string text = "1 июля.Новое в версии 1.2: Теперь вы можете получать сообщения о лайках в мобильном приложении!";
            DateTime time = DateTime.Now;

            

            NewsEvent?.Invoke(time, subscriber);
            Task.Delay(0000).Wait();
        }
    }
  
        
    
}

public class Program
{
    public static void Main(string[] args)
    {
        SocialNetwork socialNetwork = new SocialNetwork();

        // Подписка на событие
        socialNetwork.LikeEvent += (liker, liked, timestamp) =>
        {
            Console.WriteLine($"{liker} лайкнул {liked} в {timestamp}");
        };

        socialNetwork.LikeEvent += (liker, liked, timestamp) =>
        {
            Console.WriteLine($"Новый лайк: {liker} -> {liked}");
        };

        socialNetwork.LikeEvent += (liker, liked, timestamp) =>
        {
            Console.WriteLine($"{liked} был лайкнут пользователем {liker} в {timestamp}");
        };


        // Генерация лайков и уведомление подписчиков
        socialNetwork.GenerateLikes();

        Console.WriteLine();

        socialNetwork.NewsEvent += (time, subscriber) =>
        {
            Console.WriteLine($"Дата объявления: {time} Подписчик: {subscriber}");
            Console.WriteLine("1 июля.Новое в версии 1.2: Теперь вы можете получать сообщения о лайках в мобильном приложении!");
        };

        socialNetwork.GenerateNews();

    }
}
