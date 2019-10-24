using EstruturaDDD.Application.Interfaces.Apps;
using EstruturaDDD.Domain.Entities;
using EstruturaDDD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Application
{
    public class AlunoApp : IAlunoApp
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoApp(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IEnumerable<Aluno> ObterTodos()
        {
            return _alunoRepository.ObterTodos();
        }
    }
}
