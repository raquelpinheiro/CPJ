using OpimaCpj.Data.Context;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OpimaCpj.Data.Repository
{

    /// <summary>
    /// Repositorio genérico do EntityFramework.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T> where T : Entidade, new()
    {
        protected OpimaCpjContext Db;
        protected DbSet<T> DbSet;

        protected Repository(OpimaCpjContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual T Adicionar(T obj)
        {
            var objAdd = DbSet.Add(obj);
            SaveChanges();
            return objAdd.Entity;
        }

        public virtual T Atualizar(T obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            SaveChanges();

            return obj;
        }

        public virtual IEnumerable<T> Buscar(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual T ObterPorID(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(int id)
        {
            var obj = new T() { Codigo = id };


            DbSet.Remove(obj);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

    }
}
