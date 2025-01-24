



List<Person> persons = new()
{
    new() { FirstName = "Виталий", LastName = "Цаль", Age = 33 },
    new() { FirstName = "Куджо", LastName = "Джотаро", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Хованский", Age = 34 },
    new() { FirstName = "Михаил", LastName = "Петров", Age = 15 },
    new() { FirstName = "Виталий", LastName = "Гачиев", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Гагарин", Age = 34 },
};

var countYuriy = persons.Count(person => person.FirstName == "Юрий");
Console.WriteLine($"Количество людей с именем 'Юрий': {countYuriy}");

var fullNames = persons.Select(person => person.FirstName + " " + person.LastName);
Console.WriteLine("Список 'Имя Фамилия':");
foreach (var fullName in fullNames)
{
    Console.WriteLine(fullName);
}

var medialAge = persons.Average(person => person.Age);
Console.WriteLine($"Средний возраст людей в списке:{medialAge}");

var sortedByAge = persons.OrderBy(person => person.Age);
Console.WriteLine("Люди из списка отсортерованные по возрасту:");
foreach (var person in sortedByAge)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
}



public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}