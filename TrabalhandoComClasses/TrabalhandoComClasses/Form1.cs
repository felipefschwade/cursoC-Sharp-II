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
            conta.titular = new Cliente();
            conta.saldo = 300.00;
            conta.saca(250.0);
            conta.deposita(150.0);
            conta.titular.nome = "Felipe";
            conta.titular.idade = 17;
            conta.numero = 1;
            conta.titular.cpf = "asdsda12312";
            conta.agencia = 1111;

            Conta conta2 = new Conta();
            conta2.titular = new Cliente();
            conta2.saldo = 100.00;
            conta2.saca(50.0);
            conta2.deposita(150.0);
            conta2.titular.nome = "Pedro";
            conta2.numero = 1;
            conta2.titular.cpf = "asdsda12312";
            conta2.agencia = 1111;
            conta2.transfere(100, conta);

            MessageBox.Show("A conta pertence a: " + conta.titular.nome 
                            +"\n Número: " + conta.numero 
                            +"\n Agência " + conta.agencia
                            +"\n CPF: " + conta.titular.cpf
                            +"\n é de maior? " + conta.titular.ehDeMaior()
                            + "\n Saldo: " + conta.saldo);
        }
    }
}
