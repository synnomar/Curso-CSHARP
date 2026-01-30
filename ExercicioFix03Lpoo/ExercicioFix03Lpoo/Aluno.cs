using System.Globalization;

namespace ExercicioFix03Lpoo {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media() {
            return (Nota1 + Nota2 + Nota3);  
        }

        public override string ToString() {
            if (Media() >= 60) {
                return "NOTA FINAL = " + Media().ToString("F2", CultureInfo.InvariantCulture)
                + "\nAPROVADO ";
            } else {
                return
                "NOTA FINAL = " + Media().ToString("F2", CultureInfo.InvariantCulture)
                + "\nREPROVADO "
                +"\nFALTARAM "+ (60-Media())+ " PONTOS";
            }

        }

    }
}
