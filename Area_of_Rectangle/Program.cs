using System;

namespace Area_of_Rectangle
{
    class Rectangle
    {
        //member variables
        double length;
        double width;
        public void AcceptDetails()
        {
            length = 9.5;
            width = 6.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display() {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("The Length of Rectangle is: {0}", length);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("The Width of Rectangle is: {0}", width);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("The Area of Rectangle is: {0}", GetArea());
            Console.WriteLine("-------------------------------");
        }
    }
    class ExecuteRectangle {
        static void Main(string[] args) {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
