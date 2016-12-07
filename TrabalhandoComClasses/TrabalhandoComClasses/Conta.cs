namespace TrabalhandoComClasses
{
    internal class Conta
    {
        public Cliente Titular { get; set; } 
        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }

        public void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.Saldo)
            {
                if (this.Titular.ehDeMaior())
                {
                    this.Saldo -= valorASacar;
                }
                else if (valorASacar > 200)
                {
                    throw new System.Exception("O máximo que um menor de idade pode sacar é 200 R$");
                }
                else
                {
                    this.Saldo -= valorASacar;
                }

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
            this.saca(valorATransferir);
            destino.deposita(valorATransferir);
        }
    }
}