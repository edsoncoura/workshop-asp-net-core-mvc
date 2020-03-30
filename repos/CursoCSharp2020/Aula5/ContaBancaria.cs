using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Aula05
{
    class ContaBancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } 

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }   

        public ContaBancaria( int numero, string titular, double depositoIncial) : this(numero, titular)
        {
            //Saldo = saldo;//Foi alterado para chamar o deposito pois ficará mais facil a manutenção
            //futura, pois esta operação é especifica de deposito, portanto é melhor
            //chamar o metodo Deposito() aqui

            Deposito(depositoIncial);

        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo += quantia; 
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo -= (quantia + 5.00);
        }



        public override string ToString()
        {
            return "Conta " 
                + Numero
                + ", Titular: " 
                +  Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }


    }
}
