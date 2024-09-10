namespace Day_5_tgrba
{
    public class Employee
    {
        private static int _idCounter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public readonly string Gender = "female";

        public Employee()
        {
            Id = ++_idCounter;
        }
    }

    static class Example
    {
        public static void Display(this Employee[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine($"Employee ID: {arr[i].Id}");
                    Console.WriteLine($"Employee Name: {arr[i].Name}");
                    Console.WriteLine($"Employee Salary: {arr[i].Salary}");
                    Console.WriteLine($"Employee Gender: {arr[i].Gender}");
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
        public static void New(ref Employee[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = new Employee(); // Initialize each employee object
                }

                Console.WriteLine("Enter Employee Name:");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                arr[i].Salary = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            Employee[] arremp = new Employee[3];

            string[] menu = { "New", "Display", "Exit" };
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
                                New(ref arremp);
                                break;
                            case 1:
                                arremp.Display(); // Correctly use the extension method
                                break;
                            case 2:
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
