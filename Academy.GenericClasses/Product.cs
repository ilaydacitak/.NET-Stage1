using Academy.GenericClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GenericClasses
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
