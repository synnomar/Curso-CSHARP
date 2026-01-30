using System.Globalization;

namespace ExercicioLpooBanco {
    class ContaBancaria {

        //Atributos
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        private double _saldoConta;

        //Construtor
        public ContaBancaria(int numeroconta, string nometitular) {
            NumeroConta = numeroconta;
            NomeTitular = nometitular;
        }
        
        public ContaBancaria(int numeroconta, string nometitular, double saldo): this(numeroconta , nometitular) {
                _saldoConta = saldo;
        
                    
        }

        //Metodo 

        public void DepositoConta(double saldo) {
            _saldoConta += saldo;
        }

        public void SaqueConta(double saldo) { 
            _saldoConta = _saldoConta - (saldo +5);
        }

        public override string ToString() {
            return "Conta " 
                +NumeroConta
                +", Titular: "
                +NomeTitular
                +", Saldo: R$"
                +_saldoConta.ToString("F2", CultureInfo.InvariantCulture );
        }   

        

    }
}
