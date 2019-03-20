using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OpimaCPJ.Domain.Interfaces.Repository
{
    public interface IRepository<T> : IDisposable where T : Entidade
    {
        T Adicionar(T obj);
        T ObterPorID(int ID);
        IEnumerable<T> ObterTodos();
        T Atualizar(T obj);
        void Remover(int ID);
        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}
