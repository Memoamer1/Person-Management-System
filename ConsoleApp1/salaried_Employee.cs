using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class salaried_Employee : Employee
    {
        double Bonus;
        double Deduction;
        public salaried_Employee()
            : base()
        {
            Bonus = 5000;
            Deduction = 2000;
        }
        public salaried_Employee(string name, int age, string address, bool nationality, double salary, int Rank, string Job, double Bonus, double Deduction)
           : base(name, age, address, nationality, salary, Rank, Job)
        {
            this.Bonus = Bonus;
            this.Deduction = Deduction;
        }
        public void setBonus(double Bonus)
        {
            this.Bonus = Bonus;
        }
        public double getBonus()
        {
            return this.Bonus;
        }
        public void setDeduction(double Deduction)
        {
            this.Deduction = Deduction;
        }
        public double getDeduction()
        {
            return this.Deduction;
        }

    }
}
