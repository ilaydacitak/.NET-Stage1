using Academy.GenericClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GenericClasses
{
    public class CustomerServices : IRepository<Customer>
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetList()
        {
            throw new NotImplementedException();
        }
    
    }
}
