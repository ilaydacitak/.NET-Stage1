using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.AbstractClass
{
    public class SsttekStudent
    {
        private string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }

        public void SetName(string name)
        {
            Name = name + "-test";
        }

        public string GetName()
        {
            return Name;
        }


        public SsttekStudent(string name, string address)
        {
            Name = name;
            Address = address;
        }


        //parametresiz bir constructor oluşturduğumuzdan dolayı bu sınıftan bir nesne oluştururken parametre vermemize gerek kalmıyor.
        //bir sınıfın birden fazla constructoru olabilir ve bu constructorların her biri farklı parametre alıp farklı işlem yapabilir.
        public SsttekStudent()
        {


        }

    }

    public class SpecialStudent : SsttekStudent
    {
        public SpecialStudent()
        {

        }

        public string Note { get; set; }

    }
}
