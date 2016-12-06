using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Titular = new Cliente("Felipe");
            conta.deposita(300.00);
            conta.Titular.idade = 19;
            conta.saca(250.0);
            conta.deposita(150.0);
            conta.Numero = 1;
            conta.Titular.cpf = "asdsda12312";
            conta.Agencia = 1111;

            Conta conta2 = new Conta();
            conta2.Titular = new Cliente("Pedro");
            conta2.deposita(100.00);
            conta2.saca(50.0);
            conta2.deposita(150.0);
            conta2.Numero = 1;
            conta2.Titular.cpf = "asdsda12312";
            conta2.Agencia = 1111;
            conta2.transfere(100, conta);

            MessageBox.Show("A conta pertence a: " + conta.Titular.Nome 
                            +"\n Número: " + conta.Numero 
                            +"\n Agência " + conta.Agencia
                            +"\n CPF: " + conta.Titular.cpf
                            +"\n é de maior? " + conta.Titular.ehDeMaior()
                            + "\n Saldo: " + conta.Saldo);
        }
    }
}
