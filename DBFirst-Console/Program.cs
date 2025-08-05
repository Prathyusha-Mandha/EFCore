using DB_First_Console_Practice.Models;

namespace DB_First_Console_Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CodeFirstContext students = new CodeFirstContext();
            foreach (Student student in students.Students)
            {
                Console.WriteLine(student.StuId + " " + student.StudentName + " " + student.Telugu+" "+student.Hindi);
            }
        }
    }
}


