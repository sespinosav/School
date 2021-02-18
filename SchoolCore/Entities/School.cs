using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class School
    {
        string name;
        public string Name
        {
            get { return $"Copy: {name}"; }
            set { name = value.ToUpper(); }
        }
        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course> Courses { get; set; }
        public void PrintCourses()
        {
            System.Console.WriteLine("Courses of school");
            if (Courses != null)
            {
                foreach (var course in Courses)
                {
                    System.Console.WriteLine(course);
                }
            }
        }
        public School(string name, int foundationYear) => (Name, FoundationYear) = (name, foundationYear);
        public School(string name, int foundationYear, SchoolTypes schoolTypes,
                    string country = "Colombia", string city = "Medellin")
        {
            Name = name;
            FoundationYear = foundationYear;
            Country = country;
            City = city;
        }
        string n = System.Environment.NewLine;
        public override string ToString() => ($"Name: {name}, {n}SchoolType: {SchoolType}, {n}Country: {Country}, {n}City: {City}.");
    }
}
