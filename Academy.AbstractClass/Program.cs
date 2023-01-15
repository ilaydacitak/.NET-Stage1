using System;

namespace Academy.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // o işin ne olduğunu tanımlayanlardır.
            // burdaki bütün özrelliklere sahip olur. metotlar vs hepsini almalı, almazsa hata verir !!! 

            Student student = new Student(10, "İlayda");
            student.Talk();

            Console.WriteLine($"Name:{student.Name}, Age:{student.Age}");

            Employee employee = new Employee(25, "Mehmet");
            employee.Talk();
            Console.WriteLine($"Name:{employee.Name}, Age:{employee.Age}");


            SsttekStudent ssttekStudent = new SsttekStudent("İlayda", "Okul");

            Console.WriteLine($"Name:{ssttekStudent.GetName()}, Address:{ssttekStudent.Address}");


            ssttekStudent.SetName("mehmet");
            ssttekStudent.Address = "bir yer";
            Console.WriteLine($"Name:{ssttekStudent.GetName()}, Address:{ssttekStudent.Address}");


            SsttekStudent newStudent = new SsttekStudent();

            SpecialStudent specialStudent = new SpecialStudent();
            specialStudent.SetName("kalıtım");


        }

    }

    public abstract class People // abs classtan nesne üretmeyeiz.
                                 // sadece ürünlerinde neler olmalı onları belirtir
                                 // People people = new People() şeklimde OLMAZ!!!

    // İNSANLAR KONUŞUR DER.

    {
        public People(int age, string name)
        {
            Age = age;
            Name = name;

        }
        public int Age { get; set; }
        public string Name { get; set; }
        //abstract sınıfların abstract field ve metodlarını kalıtım alan sınıf override etmek zorundadır

        public abstract void Talk();


        public int GetAge()
        {
            return Age;
        }

    }

    public class Employee : People
    {
        public Employee(int age, string name) : base(age, name)
        {
        }

        //abstract sınıfların abstract field ve metodlarını kalıtım alan sınıf override etmek zorundadır

        public override void Talk()
        {
            Console.WriteLine("i am a employee");
        }
    }


    public class Student : People
    {
        public Student(int age, string name) : base(age, name)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("i am a student");
        }


    }
}
