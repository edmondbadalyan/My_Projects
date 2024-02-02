using System;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        string imagePath = "path/to/your/image.png"; // Замените на путь к вашему изображению PNG

        try
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open))
            {
                using (Image image = System.Net.Mime.MediaTypeNames.Image.FromStream(fs))
                {
                    // Ваш код обработки изображения
                    Console.WriteLine($"Ширина: {image.Width}, Высота: {image.Height}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
