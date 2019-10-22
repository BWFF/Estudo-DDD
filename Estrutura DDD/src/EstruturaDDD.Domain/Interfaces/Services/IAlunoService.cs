using EstruturaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Interfaces.Services
{
    public interface IAlunoService:IBaseService<Aluno>
    {
        IEnumerable<Aluno> ObterTodos();
    }
}
