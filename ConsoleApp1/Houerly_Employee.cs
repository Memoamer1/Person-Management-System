using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Houerly_Employee : Employee
    {
        int hours_worked;
        double hourly_rate;
        public Houerly_Employee()
            : base()
        {
            hours_worked = 40;
            hourly_rate = 20;
        }
        public Houerly_Employee(string name, int age, string address, bool nationality, double salary, int Rank, string Job, int hours_worked, double hourly_rate)
            : base(name, age, address, nationality, salary, Rank, Job)
        {
            this.hours_worked = hours_worked;
            this.hourly_rate = hourly_rate;
        }
        public void setHours_worked(int hours_worked)
        {
            this.hours_worked = hours_worked;
        }
        public int getHours_worked()
        {
            return this.hours_worked;
        }
        public void setHourly_rate(double hourly_rate)
        {
            this.hourly_rate = hourly_rate;
        }
        public double getHourly_rate()
        {
            return this.hourly_rate;
        }

    }
}
