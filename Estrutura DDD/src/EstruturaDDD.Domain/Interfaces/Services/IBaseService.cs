using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.Domain.Interfaces.Services
{
    public interface IBaseService<Entidade> where Entidade :class
    {
        IEnumerable<Entidade> ObterTodos();
    }
}
