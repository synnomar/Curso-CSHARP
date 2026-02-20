using Exemplo001MetAbstrato.Entities;
using Exemplo001MetAbstrato.Entities.Enum;
using System.Globalization;


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapesList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numOptions = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOptions; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char recOrCir = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (recOrCir == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Rectangle(width, height, color));
                 
                }
                else if (recOrCir == 'c')             
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapesList.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapesList) 
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }










        }
    }
}