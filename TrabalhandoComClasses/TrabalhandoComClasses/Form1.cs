using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhandoComClasses;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Conta conta = new ContaCorrente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta.Titular = new Cliente("Victor");
            conta.Titular.idade = 19;
            conta.deposita(250.0);
            conta.Numero = 1;

            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = conta.Titular.Nome;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValorParaDeposito.Text);
            conta.deposita(valor);
            MessageBox.Show("Saldo Anterior: " + (conta.Saldo - valor) + "\n"
                            + "Saldo Atual: " + conta.Saldo);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValorSaque.Text);
            conta.saca(valor);
            MessageBox.Show("Saldo Anterior: " + (conta.Saldo + valor) + "\n"
                            + "Saldo Atual: " + conta.Saldo);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas totalizador =  new TotalizadorDeContas();
            totalizador.adiciona(conta);
            MessageBox.Show(Convert.ToString(totalizador.saldoTotal));
        }
    }
}
