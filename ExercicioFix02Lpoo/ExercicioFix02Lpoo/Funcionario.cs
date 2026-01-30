using System.Globalization;

namespace ExercicioFix02Lpoo {
    class Funcionario {
        public string Nome;
        public double SalarioBruno;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruno - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruno += (SalarioBruno * (porcentagem / 100)); 
        }

        public override string ToString() {
            return "Funcionario: "
                + Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
