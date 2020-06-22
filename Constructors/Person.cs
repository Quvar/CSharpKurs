using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        int age;
        string firstname;
        string lastname;
        string gender;
        string address;

        public Person()
        {
            id = 1;
            age = 20;
            firstname = "Filip";
            lastname = "Dulny";
            gender = "male";
        }
        public Person(int id, int age, string firstname, string lastname, string gender, string address)
        {
            this.id = id;
            this.age = age;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
        }
        public Person(int id, int age, string firstname, string lastname)
        {
            this.id = id;
            this.age = age;
            this.firstname = firstname;
            this.lastname = lastname;
            address = "Stalowa Wola";
        }
        public Person(int id, int age)
        {
            this.id = id;
            this.age = age;
        }

    }
}
