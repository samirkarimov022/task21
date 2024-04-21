﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UlviWork.Moduls
{
    public class Student
    {
        static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Credits { get; set; }
        public Group Group { get; set; }
        public Student(string name, string surname, int age, decimal credits, Group group)
        {
            Id = _count++;
            Name = name;
            Surname = surname;
            Age = age;
            Credits = credits;
            Group = group;
        }
    }
}
