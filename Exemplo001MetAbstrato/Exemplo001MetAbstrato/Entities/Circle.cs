using Exemplo001MetAbstrato.Entities.Enum;
using System;

namespace Exemplo001MetAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius {  get; set; }

        public Circle(double radius, Color color) 
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
