using System;
using System.Text.Json;

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
        return "Name: " + Name + ", Age: " + Age + ", Hobby: " + Hobby;
    }
}
