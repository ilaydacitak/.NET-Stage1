using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GenericClasses.Abstract
{
    public  interface IRepository <T> where T : class, IEntity, new()
    {
        void Add(T model);
        void Delete(int id);
        List<T> GetList();
    }
}
