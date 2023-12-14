using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static List<Person> people;

    static void Main()
    {
        LoadDataFromJson();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Преобразовать данные в XML");
            Console.WriteLine("2. Сохранить данные в XML файл");
            Console.WriteLine("3. Вывести данные о человеке по имени");
            Console.WriteLine("4. Фильтр по языку программирования");
            Console.WriteLine("5. Выйти из программы");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertToJsonToXml();
                    break;
                case "2":
                    SaveDataToXml();
                    break;
                case "3":
                    DisplayPersonInfo();
                    break;
                case "4":
                    FilterByProgrammingLanguage();
                    break;
                case "5":
                    Environment.Exit(0);
                    Console.WriteLine("Повторите действие");
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, повторите.");
                    break;
                      
            }
        }
    }

    static void LoadDataFromJson()
    {
        string jsonContent = File.ReadAllText("data.json");
        people = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(jsonContent) ?? new List<Person>();
    }

    static void ConvertToJsonToXml()
    {
        XElement xmlData = new XElement("People",
            from person in people
            select new XElement("Person",
                new XElement("Name", person.Name),
                new XElement("Birthday", person.Birthday),
                new XElement("Height", person.Height),
                new XElement("Weight", person.Weight),
                new XElement("Car", person.Car),
                new XElement("Languages",
                    from language in person.Languages
                    select new XElement("Language", language)
                )
            )
        );

        Console.WriteLine(xmlData);
    }

    static void SaveDataToXml()
    {
        XElement xmlData = new XElement("People",
            from person in people
            select new XElement("Person",
                new XElement("Name", person.Name),
                new XElement("Birthday", person.Birthday),
                new XElement("Height", person.Height),
                new XElement("Weight", person.Weight),
                new XElement("Car", person.Car),
                new XElement("Languages",
                    from language in person.Languages
                    select new XElement("Language", language)
                )
            )
        );

        xmlData.Save("data.xml");
        Console.WriteLine("Данные успешно сохранены в файл data.xml");
    }

    static void DisplayPersonInfo()
    {
        Console.Write("Введите имя человека: ");
        string name = Console.ReadLine();

        Person person = people.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (person != null)
        {
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"День рождения: {person.Birthday}");
            Console.WriteLine($"Рост: {person.Height}");
            Console.WriteLine($"Вес: {person.Weight}");
            Console.WriteLine($"Наличие автомобиля: {person.Car}");
            Console.WriteLine($"Языки программирования: {string.Join(", ", person.Languages)}");
        }
        else
        {
            Console.WriteLine($"Человек с именем {name} не найден.");
        }
    }

    static void FilterByProgrammingLanguage()
    {
        Console.Write("Введите язык программирования: ");
        string language = Console.ReadLine().ToLower();

        List<Person> filteredPeople = people
            .Where(person => person.Languages.Contains(language, StringComparer.OrdinalIgnoreCase))
            .ToList();

        if (filteredPeople.Any())
        {
            Console.WriteLine($"Сотрудники, использующие язык программирования {language}:");
            foreach (Person person in filteredPeople)
            {
                Console.WriteLine(person.Name);
            }
        }
        else
        {
            Console.WriteLine($"Нет сотрудников, использующих язык программирования {language}.");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public string Birthday { get; set; }
    public int Height { get; set; }
    public double Weight { get; set; }
    public bool Car { get; set; }
    public List<string> Languages { get; set; }
}
