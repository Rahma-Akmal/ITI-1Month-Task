using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class _3d_point
    {
        public int  X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3d_point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public _3d_point(int x, int y, int z)
        {
            X=x; 
            Y=y; 
            Z=z;
        }
        public _3d_point(int xy) : this(xy,xy,xy) { }
        public void Display()
        {
            Console.WriteLine($"{X} ,{Y} ,{Z}");
        }

        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            X=newX; Y=newY; Z=newZ;
        }
        public static bool operator ==(_3d_point p1, _3d_point p2)
        {
            return p1.X==p2.X && p1.Y==p2.Y && p1.Z==p2.Z;

        }
        public static bool operator !=(_3d_point p1, _3d_point p2)
        {
            return  !(p1 == p2);

        }
    }
}
//_3d_point p1 = new _3d_point(1, 2, 3);
//_3d_point p2 = new _3d_point(1, 2, 3);
//p1.Display();
//p2.Display();
//Console.WriteLine($" p1==p2 {p1 == p2}");
//p1.ChangeCoordinates(2, 3, 5);
//Console.WriteLine($" p1==p2 {p1 == p2}");