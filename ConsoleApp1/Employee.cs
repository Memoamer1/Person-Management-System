using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Employee : person
    {
       public double salary;
       public int Rank;
       public string Job;
        public Employee()
            : base()
        {
            salary = 50000;
            Rank = 1;
            Job = "Employee";
        }
        public Employee(string name, int age, string address, bool nationality, double salary, int Rank, string Job)
            : base(name, age, address, nationality)
        {
            this.salary = salary;
            this.Rank = Rank;
            this.Job = Job;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return this.salary;
        }
        public void setRank(int Rank)
        {
            this.Rank = Rank;
        }
        public int getRank()
        {
            return this.Rank;
        }
        public void setJob(string Job)
        {
            this.Job = Job;
        }
        public string getJob()
        {
            return this.Job;
        }

    }
}