using System;

namespace SchoolCore.Entities
{
    public class Subject
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public Subject() => Id = Guid.NewGuid().ToString();
    }
}