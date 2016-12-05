namespace TrabalhandoComClasses
{
    internal class Conta
    {
        public Cliente titular = new Cliente();
        public double saldo;
        public int numero;
        public int agencia;

        public void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.saldo)
            {
                if (this.titular.ehDeMaior())
                {
                    this.saldo -= valorASacar;
                }
                else if (valorASacar > 200)
                {
                    throw new System.Exception("O máximo que um menor de idade pode sacar é 200 R$");
                }
                else
                {
                    this.saldo -= valorASacar;
                }
                
            }
        }

        public void deposita(double valorADepositar)
        {
            if (valorADepositar > 0)
            {
                this.saldo += valorADepositar;
            }
        }
           
        public void transfere(double valorATransferir, Conta destino)
        {
            this.saca(valorATransferir);
            destino.deposita(valorATransferir);
        }
    }
}