using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Entity;

namespace PuraSolutions.ERP.Core.Repository
{
    //public class BaseEFRepository<T>:IRepository<T> where T:class
    //{
    //    protected DbContext _entities;
    //    protected readonly IDbSet<T> _dbSet;

    //    public BaseEFRepository(DbContext context)
    //    {
    //        _entities = context;
    //        _dbSet = context.Set<T>();
    //    }

    //    public virtual void Add(T item)
    //    {
    //        _dbSet.Add(item);
    //        _entities.SaveChanges();
    //    }

    //    public virtual void Update(T Item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public virtual void Delete(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public virtual List<T> GetAll()
    //    {
    //        return _dbSet.ToList<T>();
    //    }

    //    public virtual T GetById(int Id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
