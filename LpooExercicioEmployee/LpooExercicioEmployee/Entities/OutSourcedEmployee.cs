namespace LpooExercicioEmployee.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHours, double additionalcharge) 
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalcharge;

        }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }



    }
}
