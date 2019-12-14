using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            corComboBox5.DataSource = new Repositorios.SqlServer.CorRepositorio().Ler();
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
            try
            {
                if (Formulario.Validar(this, VeiculoErrorProvider))
                {
                    GravarVeiculo();
                    MessageBox.Show("Veículo gravado com sucesso!");
                    Formulario.Limpar(this);
                    placaMaskedTextBox1.Focus();
                }
            }
            catch (FileNotFoundException excecao)
            {
                MessageBox.Show($"O arquivo {excecao.FileName} não foi encontrado.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("O arquivo veiculo.xml está com o atributo Somente leitura.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eita! Algo deu errado e em breve teremos uma solução.");
                //Logar(ex); - Log4Net
            }
            finally
            {
                //É executado sempre! Mesmo que haja algum return no código.
            }


        }

        private void GravarVeiculo()
        {
                var veiculo = new VeiculoPasseio();

                veiculo.Ano = Convert.ToInt32(anoMaskedTextBox2.Text);
                veiculo.Cambio = (Cambio)cambioComboBox4.SelectedItem;
                veiculo.Carroceria = Carroceria.Hatch;
                veiculo.Combustivel = (Combustivel)combustivelComboBox3.SelectedItem;
                veiculo.Cor = (Cor)corComboBox5.SelectedItem;
                veiculo.Modelo = (Modelo)modeloComboBox2.SelectedItem;
                veiculo.Observacao = observacaoTextBox1.Text;
                veiculo.Placa = placaMaskedTextBox1.Text.ToUpper();

                new VeiculoRepositorio().Inserir(veiculo);
        }

        private void limparButton2_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);
        }
    }
}
