using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphisms
{
    public static class Polymorphism1
    {
        public static void Run()
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Triangle(),
                new Rectangle(),
            };

            shapes.ForEach(s =>
            {
                s.Draw();
            });
        }
    }

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing task.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {nameof(Circle)}");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {nameof(Triangle)}");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {nameof(Rectangle)}");
            base.Draw();
        }
    }
}
