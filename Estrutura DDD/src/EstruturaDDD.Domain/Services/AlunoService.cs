using EstruturaDDD.Domain.Entities;
using EstruturaDDD.Domain.Interfaces.Repository;
using EstruturaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IEnumerable<Aluno> ObterTodos()
        {
            return _alunoRepository.ObterTodos();
        }
    }
}
