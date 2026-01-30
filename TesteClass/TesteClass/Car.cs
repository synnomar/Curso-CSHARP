using System;
using System.Runtime.Serialization;
using System.Globalization;


namespace TesteClass
{
    class Car
    {

        public int Id;
        public string Name;
        public string Color;
        private double _valor;

        //Construtor
        public Car(int id, string nome, string cor, double valor)
        {
            Id = id;
            Name = nome;
            Color = cor;
            Valor = valor; //Construtor envia dado para o Properties

        }

        //Metodo Alteravalor
        public void AlteraValor(double valor)
        {
            _valor = valor;
        }

        //Properties envia o dado para o metodo AlterarValor
        public double Valor
        {
            get { return _valor; }
            set { AlteraValor(value); }

        }

        //Metodo imprimir
        public override string ToString()
        {
            return "ID: "
                + Id
                + "\nNome: "
                + Name
                + "\nColor: "
                + Color
                + "\nValor: " + _valor.ToString("F2", CultureInfo.InvariantCulture);
            ;
        }

    }
}
