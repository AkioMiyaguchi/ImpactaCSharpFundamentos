using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class VeiculoRepositorio : RepositorioBase
    {
        private XDocument arquivoXml;

        public VeiculoRepositorio() : base("caminhoArquivoVeiculo")
        {
            arquivoXml = XDocument.Load(CaminhoArquivo);
        }

        public void Inserir<T>(T veiculo) where T: Veiculo
        {
            var registro = new StringWriter();
            var serializador = new XmlSerializer(typeof(T));

            serializador.Serialize(registro, veiculo);

            arquivoXml.Root.Add(XElement.Parse(registro.ToString()));
            arquivoXml.Save(CaminhoArquivo);
        }
    }
}
