namespace ConsoleApp1
{
    internal class Program
    {
        public struct employee 
        {
            public int id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public static void display(ref employee[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Employee ID: {arr[i].id}");
                Console.WriteLine($"Employee Name: {arr[i].Name}");
                Console.WriteLine($"Employee Salary: {arr[i].Salary}");
            }
            Console.ReadKey();

        }
        public static void New(ref employee[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Employee ID:");
                arr[i].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                arr[i].Salary = Convert.ToDouble(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            employee[] arremp = new employee[3];
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
                                display(ref arremp);
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