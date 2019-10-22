using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Interfaces.Repository
{
    public interface IBaseRepository<Entidade> where Entidade : class
    {
        IEnumerable<Entidade> ObterTodos();
    }
}
