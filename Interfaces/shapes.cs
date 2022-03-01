using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //creating the interface
    internal interface IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area();              
    }

    //creating a square class from the interface
    internal class Square : IShape, IColour
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Colours Colour { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
    //creating a triangle class from the interface
    internal class Triangle : IShape, IColour
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Colours Colour { get; set; }

        public double Area()
        {
            return Height * Width / 2;
        }

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
