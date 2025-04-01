using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }
        private void txtSalarioFolha_TextChanged(object sender, EventArgs e)
        {
            double salario;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, resp = 0, imp = 0;
            try
            {
                salario = Convert.ToDouble(txtSalario.Text);
                if (salario > 4464.68)
                {
                    imp = (salario * 27.5) / 100;
                    salario = salario - imp;
                }
                else if (salario >= 3751.06 && salario <= 4464.68)
                {
                    imp = (salario * 22.5) / 100;
                    salario = salario - imp;
                }
                else if (salario >= 2826.66 && salario <= 3751.05)
                {
                    imp = (salario * 15) / 100;
                    salario = salario - imp;
                }
                else if (salario >= 2259.21 && salario <= 2826.65)
                {
                    imp = (salario * 7.5) / 100;
                    salario = salario - imp;
                }
                else
                {
                    imp = 0;
                }
                txtImpostoRenda.Text = imp.ToString();

                if (chkPlanoSaude.Checked)
                {
                    salario = salario - 400;
                }

                if (cbbClubeLazer.SelectedIndex == 0)
                {
                    resp = salario;
                }
                else if (cbbClubeLazer.SelectedIndex == 1)
                {
                    resp = salario - 100;
                }
                else if (cbbClubeLazer.SelectedIndex == 2)
                {
                    resp = salario - 50;
                }
                else if (cbbClubeLazer.SelectedIndex == 3)
                {
                    resp = salario - 30;
                }
                else
                {
                    resp = salario;
                }
                txtSalarioLiquido.Text = resp.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um Valor válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSalario.Text = " ";
            txtSalario.Focus();
            chkPlanoSaude.Checked = false;
            cbbClubeLazer.Text = "";
            txtImpostoRenda.Text = " ";
            txtSalarioLiquido.Text = " ";

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
    }
