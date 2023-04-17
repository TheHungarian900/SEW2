using System;
using System.Collections.Generic;

namespace _230330_PersonFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // WOW! C# has ADTs like list!!!! 100XP
            List<Person> persons = new List<Person>();

            //100XP
            persons.Add(new Person("Oellinger", 1));
            persons.Add(new Person("A2M", long.MaxValue));

            foreach(Person p in persons)
            {
                Console.WriteLine("Person: " + p.Name + ", " + p.ID);
            }
        }
    }
}
