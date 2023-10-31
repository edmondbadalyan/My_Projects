



internal class Visit
{
    //1.Сайт собирает информацию о посетителях. Создайте класс Visit (Посещение), где хранится собранная информация о пользователе:

    //• Его браузер(Chrome, Firefox, Opera, ...)
    //• Его операционная система (Windows, iOS, Ubuntu, ...)
    //• Язык операционной системы (русский, английский, испанский, ...)
    //• Размер экрана: ширина и высота в пикселях (1920 x 1080)

    //Храните эти данные в приватных полях. Предоставьте к ним доступ только для чтения через свойства.

    //Добавьте запоминающий конструктор — конструктор, куда передают значения для всех полей.

    //Проверьте, что всё работает.


    public string Browser { get; }
    public string OperatingSystem { get; }

    public string OperatingSystemLanguage { get; }

    public string Desktop { get; }
    private static int count = 0;
    public Visit(string browser, string operatingSystem, string operatingSystemLanguage, string desktop)
    {
        Browser = browser;
        OperatingSystem = operatingSystem;
        OperatingSystemLanguage = operatingSystemLanguage;
        Desktop = desktop;
        count++;
    }
    //public override string ToString()
    //{
    //    return $"Browser: {Browser}, OS: {OperatingSystem}, Language: {OperatingSystemLanguage}, Desktop Resolution: {Desktop}";
    //}

    static void Main(string[] args)
    {
        Visit visit = new Visit("Chrome", "Linux", "English", "1980*1080");
        Console.WriteLine($"Browser: {visit.Browser}, OS: {visit.OperatingSystem}, Language: {visit.OperatingSystemLanguage}, Desktop Resolution: {visit.Desktop}");
        Console.WriteLine(count);
        Visit visit1 = new Visit("Mozilla", "Windows", "Espana", "1980*1080");
        Console.WriteLine($"Browser: {visit1.Browser}, OS: {visit1.OperatingSystem}, Language: {visit1.OperatingSystemLanguage}, Desktop Resolution: {visit1.Desktop}");
        Console.WriteLine(count);



    }
}