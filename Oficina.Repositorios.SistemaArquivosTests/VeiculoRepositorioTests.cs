using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        //VeiculoRepositorio veiculo = new VeiculoRepositorio();

        [TestMethod()]
        public void InserirTeste()
        {
            var veiculo = new Veiculo();
           
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Observacao = "Completinho";
            veiculo.Placa = "ABC1234";

            var corRepositorio = new CorRepositorio(); //forma de fazer 1

            veiculo.Cor = corRepositorio.Obter(1); //forma de fazer 1

            veiculo.Modelo = new ModeloRepositorio().Obter(1); //forma de fazer 2

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}