using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Class
{
    public class User
    {
        private string firstName;  //CamelCase
        private string lastName;
        private string email;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                //firstName = value;
                var varmi = value.Contains("a");
                if (varmi)
                {
                    firstName = "Merhaba, " + value;
                }
                else
                {
                    firstName = value;
                }
            }
        } //Property

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email { get; set; }
    }
}

