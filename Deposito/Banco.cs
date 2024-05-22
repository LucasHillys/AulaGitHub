using System;
using System.Globalization;

namespace Deposito
{
    internal class Banco
    {
        public int Conta { get; private set; }
        public string Titular { get; set;}

        public double Saldo { get; private set; }

    
        public Banco(int conta, string titular, double saldoinicial)
        {
            Conta = conta;
            Titular = titular;
            Deposito (saldoinicial);
        }

        

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            if (saque > 0) 
            {
                Saldo -= saque + 5; 
            }
            return;
            
            

        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", saldo: " + Saldo;
        }


    }
}
