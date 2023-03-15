using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        int GetId(T item);
        void Insert(T item);
        void Update(T item);
        void Delete(T item);      
    }
}
