using Oficina.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Oficina.Repositorios.SqlServer
{
    public class CorRepositorio : ICorRepositorio
    {
        private string stringConexao = ConfigurationManager.
            ConnectionStrings["oficinaSqlServer"].ConnectionString;

        public void Apagar(int Id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public List<Cor> Ler()
        {
            var cores = new List<Cor>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = "SELECT ID, NOME FROM COR ORDER BY NOME";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    using (var registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
                            cores.Add(Mapear(registros));
                        }
                    }
                }

                //conexao.Close();
            }

            return cores;
        }

        private Cor Mapear(SqlDataReader registro)
        {
            var cor = new Cor();

            cor.Id = Convert.ToInt32(registro["Id"]);
            cor.Nome = registro["Nome"].ToString();

            return cor;
        }

        public Cor Ler (int Id)
        {
            Cor cor = null;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorLer";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", Id);

                    using (var registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
                            cor = Mapear(registros);
                        }
                    }
                }

                //conexao.Close();
            }


            return cor;
        }

        public void Salvar(Cor cor)
        {
            throw new NotImplementedException();
        }
    }
}
