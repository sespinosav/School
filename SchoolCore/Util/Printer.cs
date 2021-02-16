using SchoolCore.Entities;

namespace SchoolCore.Util
{
    public static class Printer
    {
        public static void Drawline(int size = 30)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("".PadLeft(size, '='));
            System.Console.WriteLine();
        }

        public static void GeneralSchoolInformation(School School)
        {
            System.Console.WriteLine("School");
            Drawline();
            System.Console.WriteLine(School);
            Drawline();
            System.Console.WriteLine("Courses");
            foreach (Course course in School.Courses)
                System.Console.WriteLine(course);
        }
    }
}