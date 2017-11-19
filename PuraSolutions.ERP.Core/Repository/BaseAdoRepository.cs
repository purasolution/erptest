using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Utility;

namespace PuraSolutions.ERP.Core.Repository
{
    public class BaseAdoRepository<T>:IRepository<T> where T :class
    {
        public IAdoUtility<T> dbUtility { get; set; }
        public BaseAdoRepository(IAdoUtility<T> _dbutility)
        {
            dbUtility = _dbutility;
        }

        public virtual void Add(T item)
        {
            throw new NotImplementedException();
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
            return dbUtility.GetAll();
        }

        public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
