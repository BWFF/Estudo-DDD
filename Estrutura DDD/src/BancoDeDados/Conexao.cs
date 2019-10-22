using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BancoDeDados
{
    public class Conexao: IDisposable
    {
        private readonly SqlConnection _conexao;

        public Conexao()
        {
            _conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["BDSqlServer"].ConnectionString);
        }

        public SqlDataReader Consultar(string pComando)
        {
            SqlCommand comando = new SqlCommand(pComando, _conexao);
            SqlDataReader dataReaderConsulta = comando.ExecuteReader();

            return dataReaderConsulta;
        }

        public bool Manutencao(string pComando)
        {
            SqlCommand comando = new SqlCommand(pComando, _conexao);
            return (comando.ExecuteNonQuery() > 0);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
