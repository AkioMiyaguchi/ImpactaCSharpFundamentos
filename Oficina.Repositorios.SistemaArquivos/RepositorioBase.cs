using System.Configuration;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class RepositorioBase
    {
        public RepositorioBase(string caminho)
        {
            CaminhoArquivo = ConfigurationManager.AppSettings[caminho];
        }

        public string CaminhoArquivo { get; set; }

    }
}