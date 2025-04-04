using InterfaceStatic.Models;

namespace InterfaceStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sunay";
            string surname = "Kazimbeyli";
            if (Student.CheckName(name) && Student.CheckName(surname))
            {
                Student student = new Student(name, surname);
                Console.WriteLine($"Name:{name} Surname:{surname}");

                Console.WriteLine(student.GenerateEmail());
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("duzgun daxil et");
            }



        }
    }
}
