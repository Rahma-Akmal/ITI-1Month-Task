namespace MenuDay7
{
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
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
        public Employee(string gender)
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
        public static void Display(this Employee[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine(arr[i]);
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
        public static void New(Employee[] arr)
        {
            Console.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Employee Gender:");
                string gender = Console.ReadLine();
                arr[i] = new Employee(gender);

                Console.WriteLine("Enter Employee Name:");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                arr[i].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Employee Age:");
                arr[i].Age = Convert.ToInt32(Console.ReadLine());

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
                                New(arremp);
                                break;
                            case 1:
                                arremp.Display();
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
