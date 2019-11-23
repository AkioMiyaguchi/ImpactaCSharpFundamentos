using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        private XDocument arquivoXML = XDocument.Load(
            ConfigurationManager.AppSettings["caminhoArquivoModelo"]);

        public List<Modelo> ObterPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXML.Descendants("modelo"))
            {
                if (marcaId.ToString() == elemento.Element("marcaId").Value)
                {
                    var modelo = new Modelo();

                    modelo.Id = Convert.ToInt32(elemento.Element("Id").Value);
                    modelo.Nome = elemento.Element("Nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();

                    modelo.Marca = marcaRepositorio.Obter(marcaId);

                    modelos.Add(modelo);
                }
            }

            return modelos;
        }

        public Modelo Obter(int Id)
        {
            Modelo modelo = null;

            foreach (var elemento in arquivoXML.Descendants("modelo"))
            {
                if (Id.ToString() == elemento.Element("Id").Value)
                {
                    modelo = new Modelo();
                    modelo.Id = Id;
                    modelo.Nome = elemento.Element("Nome").Value;

                    var marcaRepositorio = new MarcaRepositorio();

                    modelo.Marca = marcaRepositorio.Obter(
                        Convert.ToInt32(elemento.Element("marcaId").Value));

                    break;
                }
            }

            return modelo;
        }
    }
}
