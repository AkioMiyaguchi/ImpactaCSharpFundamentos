using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo04.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Calcular()
        {
            var percentualFrete = 0M;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentualFrete = 0.2M;
                    break;

                case "ES":
                case "RJ":
                    percentualFrete = 0.3M;
                    break;

                case "MG":
                    percentualFrete = 0.35M;
                    break;

                case "AM":
                    percentualFrete = 0.6M;
                    break;

                default:
                    percentualFrete = 0.7M;
                    break;
            }

            freteTextBox.Text = percentualFrete.ToString("P2");
            totalTextBox.Text = ((1+ percentualFrete) * valor).ToString("C");

        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text == string.Empty)
            {
                erros.Add("O campo Cliente é obrigatório.");
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione uma UF.");
            }

            if (string.IsNullOrEmpty(valorTextBox.Text))
            {
                erros.Add("O campo Valor é obrigatório.");
            }
            else
            {
                decimal valorConvertido;

                if(!decimal.TryParse(valorTextBox.Text, out valorConvertido))
                {
                    erros.Add("O campo Valor deve ser numérico.");
                }
            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = "";
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Text = string.Empty;
            totalTextBox.Text = null;
        }
    }
}
