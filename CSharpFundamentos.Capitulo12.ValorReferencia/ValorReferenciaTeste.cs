using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using System.Text;

namespace CSharpFundamentos.Capitulo12.ValorReferencia
{
    [TestClass]
    public class ValorReferenciaTeste
    {
        [TestMethod]
        public void PassagemPorValorTeste()
        {
            var x = 1;
            Transformar(ref x);

            Assert.IsTrue(x == 1);
        }

        [TestMethod]
        public void PassagemPorReferenciaTeste()
        {
            var cor = new Cor() { Id = 1, Nome = "Preto" };
            Transformar(cor);

            Assert.AreEqual(cor.Nome, "Branco");
            //cor.Id = 1;
            //cor.Nome = "Preto"; 
        }

        private void Transformar(Cor cor)
        {
            cor.Nome = "Branco";
        }

        [TestMethod]
        public void PassagemPorValorRef()
        {
            var x = 1;

            Transformar(ref x);

            Assert.IsTrue(x == 2);
        }

        [TestMethod]
        public void StringsSaoImutaveisTeste()
        {
            var texto = "aaa";
            string.Concat(texto, "a");
            texto.Replace("a", "b");
            Assert.IsTrue(texto == "aaa");

            texto = string.Concat(texto, "a");
            texto = texto.Replace("a", "b");
            Assert.AreEqual(texto, "bbbb");

            var mutavel = new StringBuilder("aaa");
            mutavel.Append("a");
            mutavel.Replace("a", "b");
            Assert.IsTrue(mutavel.ToString() == "bbbb");
            Assert.AreEqual(mutavel.ToString(), "bbbb");
        }

        [TestMethod]
        public void StructTeste()
        {
            var estrutura = new Estrutura();
            estrutura.Id = 1;

            Transformar(estrutura);
            Assert.IsTrue(estrutura.Id == 1);
        }

        [TestMethod]
        public void StructVsClassTeste()
        {
            var x = 42;
            Assert.IsTrue(x.GetType().IsValueType);

            var y = new int();
            y = 10;
            Assert.IsTrue(y.GetType().IsValueType);

            var meuObjeto = new object();
            Assert.IsTrue(meuObjeto.GetType().IsClass);

            var nome = "Victor";
            Assert.IsTrue(nome.GetType().IsClass);
        }

        private void Transformar(Estrutura estrutura)
        {
            estrutura.Id = 2;
        }

        private struct Estrutura
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        private void Transformar (ref int x)
        {
            //x = x + 1;
            //x += 1;
            x++;
            //++x;
        }
    }
}
