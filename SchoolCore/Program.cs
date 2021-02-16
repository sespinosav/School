using System;
using System.Collections.Generic;
using SchoolCore.Entities;

namespace SchoolCore
{
    class Program
    {
        static void Main(string[] args)
        {  
            var engine = new EngineSchool();
            engine.Make();
            /*
            school.Courses.Add(new Course() { Name = "401", Time = TimeTypes.morning });
            school.Courses.Add(new Course() { Name = "501", Time = TimeTypes.night });

            var newCourses = new List<Course>{
                new Course()
                {
                    Name = "102",
                    Time = TimeTypes.night
                },
                new Course()
                {
                    Name = "202",
                    Time = TimeTypes.morning
                },
                new Course()
                {
                    Name = "302",
                    Time = TimeTypes.afternoon
                }
            };

            school.Courses.AddRange(newCourses);

            /**
            school.Courses = new Course[]
            {
                new Course()
                {
                    Name = "101",
                    Time = TimeTypes.night
                },
                new Course()
                {
                    Name = "201",
                    Time = TimeTypes.morning
                },
                new Course()
                {
                    Name = "301",
                    Time = TimeTypes.afternoon
                }
            };

            Console.WriteLine(school);

            var course = new Course() { Name = "103 vacational" };

            school.Courses.Add(course);

            //System.Console.WriteLine($"Course hash: {course.GetHashCode()}");

            //school.Courses.Remove(course);

            school.Courses.RemoveAll(Predicate);
            school.Courses.RemoveAll(delegate (Course course) { return course.Name == "301";});
            school.Courses.RemoveAll((Course course) => course.Name == "301");
            
            Console.WriteLine("==========================");
            printCoursesWhile(school.Courses);
            Console.WriteLine("==========================");
            printCoursesDoWhile(school.Courses);
            Console.WriteLine("==========================");
            printCoursesFor(school.Courses);
            Console.WriteLine("==========================");
            printCoursesForEach(school.Courses);
            Console.WriteLine("==========================");
            school.PrintCourses();
            */
        }

        /*
        private static bool Predicate(Course obj) => obj.Name == "301";

        private static void printCoursesForEach(Course[] courses)
        {
            foreach (Course course in courses)
                System.Console.WriteLine(course);
        }

        private static void printCoursesFor(Course[] courses)
        {
            for (int i = 0; i < courses.Length; i++)
                System.Console.WriteLine(courses[i]);
        }

        private static void printCoursesWhile(Course[] courses)
        {
            int count = 0;
            while (count < courses.Length)
            {
                System.Console.WriteLine(courses[count]);
                count++;
            }
        }

        private static void printCoursesDoWhile(Course[] courses)
        {
            int count = 0;
            do
            {
                System.Console.WriteLine(courses[count]);
                count++;
            }
            while (count < courses.Length);
        }
        */
    }
}
