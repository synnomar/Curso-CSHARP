
namespace ExercicioAbstractPayTax.Entities
{
    class PessoaJuridica : TaxPayer
    {        
        public int NumEmployees { get; set; }

        public PessoaJuridica(string name, double income, int numEmployees) 
            : base(name, income)
        {
            NumEmployees = numEmployees;
        }

        public override double CalcTax()
        {
            double tax = 0;

            if (NumEmployees >= 10){tax = (Income * 0.14);}
            else { tax = Income * 0.16; }
            return tax;
        }
    }
}
