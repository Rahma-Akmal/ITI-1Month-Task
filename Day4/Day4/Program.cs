namespace Day4
{
    using ClassLibrary1;
  
    internal class Program
    {
        struct complex
        {
            public float real;
            public float imaginary;
            public complex(float real, float imaginary)
            { 
                this.real = real;
                this.imaginary = imaginary;
            }
        }
        static complex addcomplex(complex complex1, complex complex2)
        {
            complex c1 = new complex();
            c1.real = complex1.real + complex2.real;
            c1.imaginary = complex1.imaginary + complex2.imaginary;
            return c1;
        }
        static complex subtractcomplex(complex complex1, complex complex2)
        {
            complex c1 = new complex();
            c1.real = complex1.real - complex2.real;
            c1.imaginary = complex1.imaginary - complex2.imaginary;
            return c1;
        }
        static void Main(string[] args)
        {
            employee emp=new employee(7,"rahma",7000);

            complex complex = new complex(2,10);
            complex complex1 = new complex(25,40);
            Console.WriteLine($"ADD COMPLEX REAL {addcomplex(complex, complex1).real}");
            Console.WriteLine($"ADD COMPLEX IMAginary {addcomplex(complex, complex1).imaginary}");
            Console.WriteLine($"subtract COMPLEX real {addcomplex(complex, complex1).real}");
            Console.WriteLine($"subtract COMPLEX Imaginary {addcomplex(complex, complex1).imaginary}");



        }
    }
}
