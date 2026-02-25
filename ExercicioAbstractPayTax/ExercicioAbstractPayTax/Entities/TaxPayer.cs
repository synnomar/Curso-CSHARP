
namespace ExercicioAbstractPayTax.Entities
{
    abstract class TaxPayer
    {
        public string Name {  get; set; }
        public double Income {  get; set; }

        public TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double CalcTax();

       
    }
}
