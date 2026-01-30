using ExercicioFix01Lpoo;
using System;
using System.Globalization;

namespace MyApplication {
    public class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do rêtangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = "+ retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}