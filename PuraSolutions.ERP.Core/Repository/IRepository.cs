using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuraSolutions.ERP.Core.Repository
{
    public interface IRepository<T>
    {
         void Add(T item);
         void Update(T Item);
         void Delete(T item);
         List<T> GetAll();
         T GetById(int Id);
    }
}
