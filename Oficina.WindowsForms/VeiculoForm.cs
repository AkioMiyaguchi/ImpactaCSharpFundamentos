using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    public partial class VeiculoForm : Form
    {
        //construtor - método com o mesmmo nome da classe.
        //executado automaticamente (new).
        public VeiculoForm()
        {
            InitializeComponent();

            PopularControles();
        }

        private void PopularControles()
        {
            marcaComboBox1.DataSource = new MarcaRepositorio().Obter();
            marcaComboBox1.DisplayMember = "Nome";
            marcaComboBox1.ValueMember = "Id";
            marcaComboBox1.SelectedIndex = -1;

            corComboBox5.DataSource = new CorRepositorio().Obter();
            corComboBox5.DisplayMember = "Nome";
            corComboBox5.ValueMember = "Id";
            corComboBox5.SelectedIndex = -1;

            cambioComboBox4.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox4.SelectedIndex = -1;

            combustivelComboBox3.DataSource = Enum.GetValues(typeof(Combustivel));
            combustivelComboBox3.SelectedIndex = -1;
        }

        private void marcaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (marcaComboBox1.SelectedIndex == -1)
                return;             

            var marca = (Marca)marcaComboBox1.SelectedItem;

            modeloComboBox2.DataSource = new ModeloRepositorio().ObterPorMarca(marca.Id);
            modeloComboBox2.DisplayMember = "Nome";
            modeloComboBox2.ValueMember = "Id";
            modeloComboBox2.SelectedIndex = -1;
        }

        private void gravarButton1_Click(object sender, EventArgs e)
        {
            if (Formulario.Validar(this, VeiculoErrorProvider))
            {
                GravarVeiculo();
            }
        }

        private void GravarVeiculo()
        {

        }
    }
}
