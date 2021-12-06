using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(12, 12, 12);
	    Rectangle rect = new Rectangle(12, 15);
	    Square square = new Square(4);

	    tri.GetInfo();
	    rect.GetInfo();
	    square.GetInfo();

	    Console.WriteLine(tri.GetArea());
	    Console.WriteLine(rect.GetArea());
	    Console.WriteLine(square.GetArea());
        }
    }
}
