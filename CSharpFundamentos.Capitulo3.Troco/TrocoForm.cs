using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo3.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C");
            //trocoTextBox.Text = Convert.ToString(troco);

            //Convert arredonda!!
            //int moedas1Real = Convert.ToInt32(troco);

            var moedas = new decimal[] { 1, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };

            //estrutura do for
            for (int i = 0; i < moedas.Length; i++)
            {
                moedasListView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
                troco %= moedas[i];
            }

            //estrutura do foreach
            //var j = 0;
            //foreach (var moeda in moedas)
            //{
            //    moedasListView.Items[j++].Text = ((int)(troco / moeda)).ToString();
            //    troco %= moeda;
            //}

            //--pior opção, muitas linhas de código
            //var moedas1Real = (int)troco / 1;
            //troco %= 1;

            //var moedas050 = (int)(troco / 0.5M);
            //troco %= 0.5M;

            //var moedas025 = (int)(troco / 0.25M);
            //troco %= 0.25M;

            //var moedas010 = (int)(troco / 0.10M);
            //troco %= 0.10M;

            //var moedas005 = (int)(troco / 0.05M);
            //troco %= 0.05M;

            //var moedas001 = (int)(troco / 0.01M);
            //troco %= 0.01M;

            //moedasListView.Items[0].Text = moedas1Real.ToString();
            //moedasListView.Items[1].Text = moedas050.ToString();
            //moedasListView.Items[2].Text = moedas025.ToString();
            //moedasListView.Items[3].Text = moedas010.ToString();
            //moedasListView.Items[4].Text = moedas005.ToString();
            //moedasListView.Items[5].Text = moedas001.ToString();
        }
    }
}
