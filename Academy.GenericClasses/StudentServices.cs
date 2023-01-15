using Academy.GenericClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GenericClasses
{
    public class StudentService : IRepositoryValueType<int>
    {
        public void Add(Student model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
