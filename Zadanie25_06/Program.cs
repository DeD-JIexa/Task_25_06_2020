using System;
using System.Text.Json;

namespace Zadanie25_06
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Вася", Age = 33, Hobby = new string[1] { "Футбол"} };
            Person person1 = new Person() { Name = "Влад", Age = 18, Hobby = new string[2] { "Теннис", "Футбол" } };
            Person person2 = new Person() { Name = "Json", Age = 3, Hobby = new string[3] { "Текстовый формат обмена данными, основанный на JavaScript.", "JSON легко читается людьми. Формат JSON был разработан Дугласом Крокфордом.", "Формат считается независимым от языка и может использоваться практически с любым языком программирования. Для многих языков существует готовый код для создания и обработки данных в формате JSON." } };

            #region Первый
            Console.WriteLine("Исходный объект:");
            Console.WriteLine(person);

            Console.WriteLine("Исходный объект в Json:");
            string json = JsonSerializer.Serialize<Person>(person);
            Console.WriteLine(json);

            Console.WriteLine("Исходный объект из Json:");
            Person person1DS = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(person1DS);
            #endregion
            Console.WriteLine();
            #region Второй
            Console.WriteLine("Исходный объект:");
            Console.WriteLine(person1);

            Console.WriteLine("Исходный объект в Json:");
            json = JsonSerializer.Serialize<Person>(person1);
            Console.WriteLine(json);

            Console.WriteLine("Исходный объект из Json:");
            Person person2DS = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(person2DS);
            #endregion

            #region Json
            Console.WriteLine("Исходный объект:");
            Console.WriteLine(person2);

            Console.WriteLine("Исходный объект в Json:");
            json = JsonSerializer.Serialize<Person>(person2);
            Console.WriteLine(json);

            Console.WriteLine("Исходный объект из Json:");
            Person person3DS = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(person3DS);
            #endregion
            Console.ReadLine();
        }
    }
}
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string[] Hobby { get; set; }

    public override string ToString()
    {
        string hoby = ""; //перебор
        for (int i = 0; i < Hobby.Length; i++)
        {
            if (i < Hobby.Length - 1)
            {
                hoby += Hobby[i] + ", ";
            }
            else
            {
                hoby += Hobby[i] + ".";
            }
        }
        return "Имя: " + Name + ", Возраст: " + Age + ", Увлечение: " + hoby;
    }
}