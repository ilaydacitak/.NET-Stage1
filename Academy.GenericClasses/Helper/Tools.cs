using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GenericClasses.Helper
{
    public class Tools
    {
        public List<T> CreateList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
