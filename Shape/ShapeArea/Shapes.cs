using System;
using System.Linq;

namespace ShapeArea
{
    public class InvalidShapeException : Exception
    {
        public InvalidShapeException() { }
        public InvalidShapeException(string message) : base(message) { }
        public InvalidShapeException(string message, Exception inner) : base(message, inner) { }
    }
    public abstract class Shape
    {
        public abstract double Area();
        public abstract override string ToString();
        public static readonly double double_threshold = 0.0001; //"zero" for double type comparison
    }

    public class Triangle : Shape
    {
        //Possible types of triangle
        private enum TriangleType : ushort
        {
            Undefined,
            Right,
            Oblique
        }
        private readonly double[] sides;
        private double area_value = -1.0;
        private TriangleType is_right = TriangleType.Undefined;
        public Triangle(double side1, double side2, double side3)
        {
            //All possible incorrect inputs
            bool incorrect = (
              side1 <= 0.0 || side2 <= 0.0 || side3 <= 0.0 ||
              side1 + side2 - side3 <= double_threshold ||
              side1 + side3 - side2 <= double_threshold ||
              side2 + side3 - side1 <= double_threshold
            );
            if (incorrect)
            {
                throw new InvalidShapeException("Triangle is invalid");
            }
            sides = new double[] { side1, side2, side3 };
        }
        public bool IsRight()
        {
            //"Lazy" approach
            if (is_right == TriangleType.Undefined)
            {
                //
                double[] squared_sides = sides.Select(elem => Math.Pow(elem, 2)).ToArray();
                Array.Sort(squared_sides);
                is_right = (Math.Abs(squared_sides[0] + squared_sides[1] - squared_sides[2]) < double_threshold) ? TriangleType.Right : TriangleType.Oblique;
            }
            return is_right == TriangleType.Right;
        }
        public override double Area()
        {
            //"Lazy" approach
            if (area_value < 0.0)
            {
                //area = sqrt(p * (p - a) * (p - b) * (p - c)), p=P/2  <-- Heron's formula
                double half_perimeter = sides.Sum() / 2.0;
                area_value = half_perimeter;
                foreach (double side in sides)
                {
                    area_value *= half_perimeter - side;
                }
                area_value = Math.Sqrt(area_value);
            }
            return area_value;
        }
        public override string ToString()
        {
            return $"Triangle ({sides[0]}, {sides[1]}, {sides[2]})";
        }
    }

    public class Circle : Shape
    {
        private readonly double radius;
        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new InvalidShapeException("Circle radius is invalid");
            }
            this.radius = radius;
        }
        public override double Area()
        {
            //area = Pi * (r ^ 2)
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return $"Circle ({radius})";
        }
    }
}
