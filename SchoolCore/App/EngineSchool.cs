using System.Collections.Generic;
using System.Linq;
using SchoolCore.Entities;
using SchoolCore.Util;

namespace SchoolCore
{
    public class EngineSchool
    {
        public School School { get; set; }

        public EngineSchool()
        {
            School = new School("Platzi", 2008, SchoolTypes.Primary, city: "Bogota");
            School.Country = "Colombia";
            School.City = "Medellin";
        }

        public void Make()
        {
            makeCourses();
            makeSubjects();
            makeAlumns();

            Printer.GeneralSchoolInformation(School);
        }

        private void makeAlumns(int quantity = 50)
        {
            string[] names = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastNames = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] secondNames = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var alumns = from name in names
                         from lastName in lastNames
                         from secondName in secondNames
                         select new Alumn { Name = $"{name} {secondName} {lastName}" };

            foreach (var course in School.Courses)
            {
                course.Alumns = alumns.OrderBy((alumn) => alumn.Id).Take(quantity).ToList();
            }
        }

        private void makeSubjects()
        {
            foreach (var course in School.Courses)
            {
                course.Subjects = new List<Subject>(){
                    new Subject()
                    {
                        Name = "mathematics",
                    },
                    new Subject()
                    {
                        Name = "english",
                    },
                    new Subject()
                    {
                        Name = "economic",
                    }
                };
            }
        }

        private void makeCourses()
        {
            School.Courses = new List<Course>{
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
        }
    }
}