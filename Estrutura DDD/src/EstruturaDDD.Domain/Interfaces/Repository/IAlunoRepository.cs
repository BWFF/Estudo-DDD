using EstruturaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Interfaces.Repository
{
    public interface IAlunoRepository: IBaseRepository<Aluno>
    {
        IEnumerable<Aluno> ObterTodos();
    }
}
