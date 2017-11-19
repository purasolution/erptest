using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuraSolutions.ERP.Core.Business
{
    public interface IBusinessService<T>
    {
        void Add(T item);
        void Update(T Item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int Id);
    }
}
