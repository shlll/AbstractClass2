using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public override void CalculateArea()
        {
            var area = Width * Length;
            Console.WriteLine($"The area : {area}");
            Console.ReadLine();

        }
        public override void CalculatePerimeter()
        {
            var perimeter = (Width + Length) * 2;
            Console.WriteLine($"The perimeter : {perimeter}");
            Console.ReadLine();
        }
    }
}
