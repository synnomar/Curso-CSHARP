using System;
using TesteClass;

namespace MyApllication
{
    class Program
    {

        static void Main(string[] args)
        {

            //DECLARA O OBJETO
            Car car;

            //CHAMADAS DO USUARIO
            Console.Write("Digite o ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Digite o Valor: ");
            double valor = double.Parse(Console.ReadLine());

            //INSTANCIA O OBJETO
            car = new Car(id, nome, cor, valor);

            //RETORNO DOS DADOS
            Console.WriteLine();
            Console.WriteLine(car);

            //CHAMA O METODO ALTERAR VALOR
            Console.WriteLine();
            Console.Write("Digite novo valor: ");
            car.AlteraValor(double.Parse(Console.ReadLine()));

            //RETORNO DOS DADOS
            Console.WriteLine();
            Console.WriteLine(car);




        }

    }

}