using System;
using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class Course
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public TimeTypes Time { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Alumn> Alumns { get; set; }
        public Course() => Id = Guid.NewGuid().ToString();
        public override string ToString() => ($"Name: {Name}, Id: {Id}");
    }
}