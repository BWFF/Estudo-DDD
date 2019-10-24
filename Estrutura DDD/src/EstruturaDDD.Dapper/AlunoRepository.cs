using BancoDeDados;
using EstruturaDDD.Domain.Entities;
using EstruturaDDD.Domain.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Dapper
{
    public class AlunoRepository : BaseRepository
    {
        public AlunoRepository(IConfiguration AppConfig) : base(AppConfig)
        {
        }

        public IEnumerable<Aluno> ObterTodosAlunos()
        {
            using (Conexao conexao = new Conexao(BdConnectionString))
            {
                string script = @"SELECT IDTALUNO, CODALUNO, NOMEALUNO, CELALUNO, DTINICIOALUNO, DIAVENCALUNO, STATUSALUNO, VALORDESCONTOALUNO 
                                  FROM TBALUNOS";

                return (IEnumerable<Aluno>)conexao.Consultar(script);
            }
        }
    }
}
