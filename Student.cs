using InterfaceStatic.Interfaces;

namespace InterfaceStatic.Models
{
    class Student : ICodeAcademy
    {
        public static int Count = 0;
        private int Id { get; }
        private string _name;
        private string _surname;

        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (CheckName(value))
                {
                    _surname = value;
                }

            }

        }

        public string CodeEmail { get; set; }
        public string GenerateEmail()
        {
            return string.Concat(Name.ToLower(), ".", Surname.ToLower(), Id, "@code.edu.az");

        }

        public Student(string name, string surname)
        {
            Count++;
            Id = Count;
            Name = name;
            _surname = surname;
            CodeEmail = GenerateEmail();

        }
        public static string Capitalize(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();

        }

        public static bool CheckName(string value)
        {
            if (value.Length >= 3 && value.Length <= 25 && value.All(char.IsLetter))
            {
                return true;
            }

            else return false;
        }

    }
}
