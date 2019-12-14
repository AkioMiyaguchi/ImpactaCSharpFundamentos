using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.Interfaces
{
    public interface ICorRepositorio
    {
        int Salvar(Cor cor);
        List<Cor> Ler();
        void Apagar(int Id);
        void Atualizar(Cor cor);
    }
}
