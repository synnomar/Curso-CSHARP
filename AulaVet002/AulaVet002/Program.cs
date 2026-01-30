using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http.Headers;

namespace Myapplication {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de produtos para cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i  = 0; i < n; i++) {
                Console.Write($"Entre com o nome do Produto {i+1}: ");
                string name = Console.ReadLine();
                Console.Write($"Entre com o valor do Produto {name}: ");
                double preco = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                vect[i] = new Product{ NomeProduto = name, ValorProduto = preco};
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].ValorProduto;
            }
            Console.WriteLine("A media de preço é: " + (sum / n).ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}