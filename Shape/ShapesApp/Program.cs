using System;
using System.Linq;
using ShapeArea;

/* TASK:
 * ------
 * Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
 * Дополнительно к работоспособности оценим:

    + Юнит-тесты
    + Легкость добавления других фигур
    + Вычисление площади фигуры без знания типа фигуры
    + Проверку на то, является ли треугольник прямоугольным
*/

namespace ShapesApp
{
    //Example of easily made additional type of shape: a regular polygon.
    class RegularPolygon : Shape
    {
        private readonly int quantity;
        private readonly double length;
        private double area_value = -1.0;
        public RegularPolygon(int quantity_of_sides, double length_of_one)
        {
            quantity = quantity_of_sides;
            length = length_of_one;
        }
        public override string ToString()
        {
            return $"Right polygon ({length} x {quantity} sides)";
        }
        public override double Area()
        {
            if (area_value < 0.0)
            {
                double radius = length / 2.0 * Math.Tan(Math.PI / quantity);
                area_value = radius * quantity * length / 2.0;
            }
            return area_value;
        }
    }
    class Program
    {
        static void Main()
        {
            var rnd = new Random();
            Shape[] shapes = new Shape[] {
                new Triangle(3, 4, 5),
                new Triangle(3, 4, 4),
                new Circle(2),
                new RegularPolygon(6,8)
            };
            var unordered_shapes = shapes.OrderBy(shape => rnd.Next());  
            foreach (Shape one_shape in unordered_shapes)
            {
                Console.WriteLine(one_shape.ToString());
                Console.WriteLine($"Area:{one_shape.Area()}");                
                if (one_shape.GetType() == typeof(Triangle))
                {
                    string right = ((Triangle)one_shape).IsRight() ? "" : "not ";
                    Console.WriteLine($"This is {right}a right triangle");
                }
                Console.WriteLine();               
            }
        }
    }
}
