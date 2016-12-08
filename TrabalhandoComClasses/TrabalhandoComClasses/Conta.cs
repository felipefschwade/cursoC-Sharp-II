using System;

namespace TrabalhandoComClasses
{
    internal class Conta
    {
        public Cliente Titular { get; set; } 
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }

        public virtual void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.Saldo)
            {
                this.Saldo -= valorASacar;
            }
            else
            {
                throw new System.Exception("Você não possui saldo para este saque");
            }
        }

        public void deposita(double valorADepositar)
        {
            if (valorADepositar > 0)
            {
                this.Saldo += valorADepositar;
            }
        }
           
        public void transfere(double valorATransferir, Conta destino)
        {
            if (destino.Equals(this))
            {
                throw new InvalidOperationException("Você não pode realizar uma transferência para você mesmo");
            }
            this.saca(valorATransferir);
            Console.WriteLine(this.Saldo);
            destino.deposita(valorATransferir);
            Console.WriteLine(this.Saldo);
        }
    }
}