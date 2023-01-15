using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Class
{
    public class UserService : IUserService //PascalCase
    {
        public User GetByUser()
        {
            throw new System.NotImplementedException();
        }
        // private olanlara sadece class içerisinden erişim salanabilir.
        //private string FirstName;
        //private string LastName;
        /*private string email;


        //public olanlara dışarıdan da ulaşım sağlanabilir.

        // böyle de tanımlanabilir ama genelde tercih etmeyiz. Buna fileld deriz.
        // public string firstName; 
        public string firstName //property
        {
            get
            {
                return firstName; //CamelCase
            }
            set 
            {
                // default hali budur 
                //firstName = value; 

                var varMi = value.Contains("a");
                if(varMi) 
                {
                    firstName = "Merhaba, " + value; 
                }
                else
                {
                    firstName = value;
                }
            }
        } 
        public string lastName { get; set; }
        public string Email { get; set; }*/

    }
}
