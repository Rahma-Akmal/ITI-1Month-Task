namespace MenuDay8
{
    public enum Gender
    {
        Male,
        Female
    }

    
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return $"Age is {Age} and Name is: {Name} and Gender is {Gender}";
        }
    }
    public class Employee : Human
    {
        public int Id { get; private set; }
        private static int _idCounter = 0;
        public double Salary { get; set; }
        public Employee(Gender gender)
        {
            Id = ++_idCounter;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID is {Id}\nName is {Name}\nGender is {Gender}\nAge is {Age}\nSalary is {Salary}\n";
        }
    }

    static class Example
    {
        public static void Display(this List<Employee> arr)
        {
            Console.Clear();
            foreach (var e in arr)
            {
                {
                    if (e != null)
                    {
                        Console.WriteLine(e);
                    }
                    else
                    {
                        Console.WriteLine("No data for this employee.");
                    }
                }
                Console.ReadKey();
            }
        }

        internal class Program
        {
            public static void New(List<Employee> arr)
            {
                Console.Clear();
                bool addMore = true;

                while (addMore)
                {
                    Gender gender;

                    while (true)
                    {
                        Console.WriteLine("Enter Employee Gender (Male/Female):");
                        string genderInput = Console.ReadLine();
                        if (Enum.TryParse(genderInput, true, out gender))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid gender (Male or Female).");
                        }
                    }
                    var employee = new Employee(gender);

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter Employee Name:");
                            employee.Name = Console.ReadLine();
                            if (string.IsNullOrEmpty(employee.Name))
                            {
                                throw new ArgumentNullException("Name cannot be empty");
                            }
                            break;
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Please enter a valid name.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter Employee Salary:");
                            employee.Salary = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid salary.");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter Employee Age:");
                            employee.Age = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid age.");
                        }
                    }

                    arr.Add(employee);

                    Console.WriteLine("Do you want to add another employee? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes")
                    {
                        addMore = false;
                    }
                }
            }

            static void Main(string[] args)
            {
                List<Employee> arremp = new List<Employee>();

                string[] menu = { "New", "Sort", "Display", "Exit" };
                int position = 0;
                bool loop = true;
                int xshift = Console.WindowWidth / 2;
                int yshift = Console.WindowHeight / (menu.Length + 1);
                do
                {
                    Console.Clear();
                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == position)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Console.SetCursorPosition(xshift, yshift * (i + 1));
                        Console.Write(menu[i]);
                    }
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            position--;
                            if (position < 0)
                            {
                                position = menu.Length - 1;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            position++;
                            if (position > menu.Length - 1)
                            {
                                position = 0;
                            }
                            break;
                        case ConsoleKey.Home:
                            position = 0;
                            break;
                        case ConsoleKey.End:
                            position = menu.Length - 1;
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            switch (position)
                            {
                                case 0:
                                    New(arremp);
                                    break;
                                case 1:
                                    Console.WriteLine("Sort By Name Or Salary");
                                    string sortby = Console.ReadLine();
                                    if (sortby == "Salary")
                                    {
                                        Console.WriteLine("Asc or Desc");
                                        string order = Console.ReadLine();
                                        if (order == "Asc")
                                        {
                                            Console.WriteLine("Sort By Salary Asc");
                                            arremp.Sort((c1, c2) =>c1.Salary.CompareTo(c2.Salary));
                                            arremp.Display();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sort By Salary Dsc");
                                            arremp.Sort((c1, c2) => -1* c1.Salary.CompareTo(c2.Salary));
                                            arremp.Display();
                                        }
                                       

                                    }
                                    if (sortby == "Name")
                                    {
                                        Console.WriteLine("Asc or Desc");
                                        string order = Console.ReadLine();
                                        if (order == "Asc")
                                        {
                                            Console.WriteLine("Sort By Name Asc");

                                            arremp.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
                                            arremp.Display();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sort By Name Dsc");

                                            arremp.Sort((c1, c2) => -1* c1.Name.CompareTo(c2.Name));
                                            arremp.Display();
                                        }

                                    }
                                        

                                    

                                    break;
                                case 2:
                                    arremp.Display();
                                    break;
                                case 3:
                                    Console.Clear();
                                    loop = false;
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            loop = false;
                            break;
                    }
                } while (loop);
            }
        }
    }
}
