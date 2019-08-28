using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (dgvContas.Rows.Count == 0)
            {
                dgvContas.ColumnCount = 2;
                dgvContas.Columns[0].Name = "Nome";
                dgvContas.Columns[1].Name = "Saldo (R$)";
            }

            string[] linha = new string[]
            {
                txtNome.Text,
                nudSaldo.Value.ToString()
            };
            dgvContas.Rows.Add(linha);
        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow l = dgvContas.SelectedRows[0];
            string nome = l.Cells[0].Value.ToString();
            double saldo = Convert.ToDouble(l.Cells[1].Value);

            Conta cc = new Conta(nome, saldo);
            cc.Credito(Convert.ToDouble(nudValor.Value));
            l.Cells[1].Value = cc.getSaldo();
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow l = dgvContas.SelectedRows[0];
            string nome = l.Cells[0].Value.ToString();
            double saldo = Convert.ToDouble(l.Cells[1].Value);

            Conta cc = new Conta(nome, saldo);
            cc.Debito(Convert.ToDouble(nudValor.Value));
            l.Cells[1].Value = cc.getSaldo();
        }
    }
}
