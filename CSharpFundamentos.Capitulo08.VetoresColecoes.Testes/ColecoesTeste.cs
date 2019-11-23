using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>() { 1, 8, 33, 16, -78};
            inteiros.Add(27);
            inteiros.Add(-8);

            var maisInteiros = new List<int> { 16, 38, -7, 8};

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(2, 42); //não subscreve, empurra os outros elementos do vetor

            inteiros.Remove(42); //remove apenas a primeira ocorrência do item
            inteiros.RemoveAll(inteiro => inteiro == 16); //lâmbda expression
            inteiros.RemoveAt(5); // remove pelo índice

            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros[inteiros.Count - 1];
            ultimo = inteiros.Last();

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}"); //interpolação
            }

        }


        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019, 11, 15), "Proclamação da República");
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Conciência Negra");
            feriados.Add(Convert.ToDateTime("25/01/2020"), "Aniversário de São Paulo");

            var proclamacao = feriados[new DateTime(2019, 11, 15)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}: {feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("20/11/2019")));
            Console.WriteLine(feriados.ContainsValue("Proclamação da República"));
        }

    }
}
