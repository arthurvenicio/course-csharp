using System.Collections.Generic;
using CourseCSharp.Entities;
using System;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> CourseA = new HashSet<Student>();
            HashSet<Student> CourseB = new HashSet<Student>();
            HashSet<Student> CourseC = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseA.Add(new Student { Id = id});
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseB.Add(new Student { Id = id});
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseC.Add(new Student { Id = id});
            }

            HashSet<Student> all = new HashSet<Student>(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);

            Console.WriteLine($"Total students: {all.Count}");
        }
    }
}
