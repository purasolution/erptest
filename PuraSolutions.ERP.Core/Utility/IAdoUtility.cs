using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Utility
{
    public interface IAdoUtility<T> where T:class
    {
        void Add(T item);
        void Update(T Item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int Id);
    }
}
