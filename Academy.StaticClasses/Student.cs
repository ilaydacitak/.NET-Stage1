using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.StaticClasses
{
    public class Student
    {
        public readonly string _connectionString = "abcdefg";

        public readonly string SecretName = "";  // constructor veya başlangıcta değer atabilirsin ama başka zaman setleyemezsin

        public const string SecretMail = "***"; //bu değer sonradan değiştirilmez.


        /*public Student(string secretName)
        {
            SecretName = secretName;
        }*/

        public Student(string _ConnectionString)
        {
            _connectionString = _ConnectionString;
        }



        /*public void SetName(string newName) 
        {
            SecretName = newName;                // BU OLMAZ 
        }*/
    }
}
