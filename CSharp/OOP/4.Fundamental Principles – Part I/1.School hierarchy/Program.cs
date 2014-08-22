﻿using System;

// We are given a school. In the school there are classes of students. Each class has a set of teachers. 
// Each teacher teaches a set of disciplines. Students have name and unique class number. 
// Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
// Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments 
// (free text block).
// Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
// define the class hierarchy and create a class diagram with Visual Studio.

namespace _1.School_hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho", "#2341");
            Teacher teachar = new Teacher("Mr. Dimitrov");

            teachar.AddDiscipline(new Discipline("Math"));
            teachar.AddDiscipline(new Discipline("Mechanics"));

            Console.WriteLine(student);
            Console.WriteLine(teachar);
            Console.WriteLine(teachar.ShowDiscipline());
        }
    }
}
