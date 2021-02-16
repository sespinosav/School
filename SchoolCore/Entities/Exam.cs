using System;

namespace SchoolCore.Entities
{
    public class Exam
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public double Grade { get; set; }
        public Exam(double grade, string subject) {
            Id = Guid.NewGuid().ToString();
            Grade = grade;
            Subject = subject;
        } 
    }
}