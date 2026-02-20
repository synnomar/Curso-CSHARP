using System;
using System.Collections.Generic;
using Exemplo001MetAbstrato.Entities.Enum;


namespace Exemplo001MetAbstrato.Entities
{
    abstract class Shape
    {
        
        public Color Color { get; set; }

        public Shape(Color color) 
        { 
            Color = color;
        }

        

        public abstract double Area();
         
    }
}
