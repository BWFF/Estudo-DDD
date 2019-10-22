using EstruturaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Application.Interfaces.Apps
{
    public interface IAlunoApp
    {
        IEnumerable<Aluno> ObterTodos();
    }
}
