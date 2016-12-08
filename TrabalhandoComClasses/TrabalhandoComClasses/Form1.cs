using System;
using System.Windows.Forms;
using TrabalhandoComClasses;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        Conta conta = new ContaCorrente();
        Conta cp = new ContaPouopanca();
        
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

            cp.Titular = new Cliente("Cezar");
            cp.Titular.idade = 19;
            cp.deposita(250.0);
            cp.Numero = 2;

            banco.adicionaConta(conta);
            banco.adicionaConta(cp);

            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    comboTitulares.Items.Add(c.Titular.Nome);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValorParaDeposito.Text);

            int index = comboTitulares.SelectedIndex;

            banco.Contas[index].deposita(valor);

            MessageBox.Show("Saldo Anterior: " + (conta.Saldo - valor) + "\n"
                            + "Saldo Atual: " + conta.Saldo);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboTitulares.SelectedIndex;

            double valor = Convert.ToDouble(textoValorSaque.Text);
            banco.Contas[index].saca(valor);
            MessageBox.Show("Saldo Anterior: " + (banco.Contas[index].Saldo + valor) + "\n"
                            + "Saldo Atual: " + banco.Contas[index].Saldo);
            textoSaldo.Text = Convert.ToString(banco.Contas[index].Saldo);
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
            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    totalizador.adiciona(c);
                }
            }
            MessageBox.Show(Convert.ToString(totalizador.saldoTotal));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = comboTitulares.SelectedIndex;
            MessageBox.Show("Conta Número: " + banco.Contas[index].Numero + "\n"
                                + "Saldo: " + banco.Contas[index].Numero);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboTitulares.SelectedIndex;

            textoNumero.Text = Convert.ToString(banco.Contas[index].Numero);
            textoSaldo.Text = Convert.ToString(banco.Contas[index].Saldo);
            textoTitular.Text = banco.Contas[index].Titular.Nome;
        }
    }
}
