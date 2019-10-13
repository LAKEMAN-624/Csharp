﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persion1 = new Person();
            Person person2 = new Person();
            persion1.Name = "Deer";
            person2.Name = "Deer's wife";
            
            List<Person> nation = Person.GetMarry(persion1, person2);
            //Console.WriteLine(nation);
            foreach (var p in nation)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
    class Person
    {
        public string Name;
        public static List<Person> GetMarry(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        }
    }
}
