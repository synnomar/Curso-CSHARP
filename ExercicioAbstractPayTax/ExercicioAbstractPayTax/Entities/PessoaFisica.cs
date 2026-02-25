
namespace ExercicioAbstractPayTax.Entities
{
    class PessoaFisica : TaxPayer
    {
       
        public double HealthExpanded { get; set; }

        public PessoaFisica(string name, double income, double healthExpanded) 
            : base(name, income)
        {
            HealthExpanded = healthExpanded;
        }

        public override double CalcTax()
        {
            double tax = 0;
            if (Income >= 20000)
            {
                tax = (Income * 0.25) - (HealthExpanded * 0.5);
            }
            else
            {
                tax = (Income * 0.15) - (HealthExpanded * 0.5);
            }
                return tax;
                
        }
    }
}
