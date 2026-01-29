using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class person
    {
        public string name;
        public int age;
        public string address;
        public bool nationality;

        public person()
        {
            name = "John Doe";
            age = 30;
            address = "123 Main St, Anytown, USA";
        }
        public person(string name, int age, string address, bool nationality)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.nationality = nationality;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }
        public void setNationality(bool nationality)
        {
            this.nationality = nationality;
        }
        public bool isNationality()
        {
            return nationality;
        }
    }
}
