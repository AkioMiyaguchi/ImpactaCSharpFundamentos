using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];
            inteiros[0] = 14;
            //inteiros[5] = 4; isso está errado

            var decimais = new decimal[] { 0.4M, 0.9M, 4, 7.8M};

            string[] nomes = { "Akio", "Miyaguchi"};

            foreach (var item in decimais)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"O tamanho do vetor Decimais é: {decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5M, 7, 8.9M };

            Array.Resize(ref decimais, 5);

            decimais[4] = 2.3M;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5M, 7, 0.9M, -1.4M};

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -1.4M);
        }

        [TestMethod]
        public void ParamsTest()
        {
            var decimais = new decimal[] { 0.5M, 7, 0.9M, -1.4M };

            Console.WriteLine(Media(decimais));
            Console.WriteLine(Media(1.5M, 8, 0.5M, 25));
            Console.WriteLine(decimais.Average());
        }

        private decimal Media(decimal valor1, decimal valor2)
        {
            return (valor1 + valor2) / 2;
        }

        private decimal Media(params decimal[] valores)
        {          
            var soma = 0M;
            var quantidade = valores.Length;

            foreach (var item in valores)
            {
                soma += item; 
            }

            return soma / quantidade;
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Akio";

            Assert.AreEqual(nome[0], 'A');

            foreach (var _char in nome)
            {
                Console.WriteLine(_char);
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
