using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuraSolutions.ERP.Core.Repository;

namespace PuraSolutions.ERP.Core.Business
{
   public  class BaseBusinessService<T>:IBusinessService<T>
    {
       protected IRepository<T> _repository;
       public BaseBusinessService(IRepository<T> repository)
       {
           _repository = repository;
       }

       public virtual void Add(T item)
        {
            _repository.Add(item);
       }

       public virtual void Update(T Item)
        {
            throw new NotImplementedException();
        }

       public virtual void Delete(T item)
        {
            throw new NotImplementedException();
        }

       public virtual List<T> GetAll()
        {
            return _repository.GetAll();
        }

       public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
