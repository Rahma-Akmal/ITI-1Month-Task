namespace Day6
{
    public class GeoShape
    {
        protected double d1 { get; set; }
        protected double d2 { get; set; }
        public GeoShape()
        {
            d1 = d2 = 1;
        }
        public GeoShape(double n)
        {
            d1 = d2 = n;
        }
        public GeoShape(double n1, double n2)
        {
            d1 = n1;
            d2 = n2;

        }
        public virtual double calcarea()
        {
            return 0;
        }
    }
    public class circle : GeoShape
    {
        public circle(int n) : base(n)
        {

        }
        public double raduis { get { return d1; } set { d1 = value; } }
        public override double calcarea()
        {
            return Math.PI * Math.Pow(raduis, 2);
        }

    }
    public class rectangle : GeoShape
    {
        public rectangle(double n, double n1) : base(n, n1)
        {

        }
        public double Width { get { return d1; } set { d1 = value; } }
        public double Height { get { return d2; } set { d2 = value; } }
        public override double calcarea()
        {
            return Width * Height;
        }
    }
    public class traingle : GeoShape
    {
        public traingle(double n1, double n2) : base(n1, n2)
        {

        }
        public double Base { get { return d1; } set { d1 = value; } }
        public double Height { get { return d2; } set { d2 = value; } }


        public override double calcarea()
        {
            return 0.5 * Base * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle(8);
            Console.WriteLine($"area of circle {c.calcarea()}");
            traingle t = new traingle(20, 15);
            Console.WriteLine($"area of traingle {t.calcarea()}");
            rectangle r = new rectangle(10, 12);
            Console.WriteLine($"area of rectangle {r.calcarea()}");
            GeoShape[] garr = { c, t, r };
            double sum = 0;
            foreach (var item in garr)
            {
                sum += item.calcarea();

            }
            Console.WriteLine(sum);

        }
    }
}
