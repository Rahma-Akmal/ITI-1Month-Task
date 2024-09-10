using ClassLibraryForms;
namespace Day7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DrawingClass.StartDraw(800,600,"Gggg");

            Line line = new Line(200,200,150,150,System.Drawing.Color.Blue);
            Circle c = new Circle(180, 180, 70, System.Drawing.Color.Aqua);
            Rect rect =new Rect(150,150,100,130,Color.Beige);
            Shape[] shapes = {line,c, rect};
            Picture p =new Picture(shapes);
            p.DrawPicture();
            DrawingClass.EndDraw();

        }
    }
}
