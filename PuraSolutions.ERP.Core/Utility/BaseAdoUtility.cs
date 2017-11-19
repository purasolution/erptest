using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Utility
{
    public class BaseAdoUtility<T>: IAdoUtility<T>  where T:class
    {

        public BaseAdoUtility()
        {
         
            
        }
        public BaseAdoUtility(string Connectionstring)
        {
          
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
            throw new NotImplementedException();
        }

        public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
