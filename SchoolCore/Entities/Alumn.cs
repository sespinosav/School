using System;
using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class Alumn
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public List<Exam> Exams { get; set;} = new List<Exam>();
        public Alumn() {
            Id = Guid.NewGuid().ToString();
            var random = new Random();
            string[] subjects = {"mathematics","economic","english"};
            foreach (var subject in subjects)
            {
                for (int i = 0; i < 5; i++)
                {
                    Exams.Add(new Exam(5 * random.NextDouble(),subject));
                }
            }
        } 
    }
}