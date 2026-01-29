using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class student : person
    {
        public string student_level;
        public string specialization;
        public int GPA;
        public student() : base()
        {
            student_level = "Undergraduate";
            specialization = "Computer Science";
            GPA = 4;
        }
        public student(string name, int age, string address, bool nationality, string student_level, string specialization, int GPA)
            : base(name, age, address, nationality)
        {
            this.student_level = student_level;
            this.specialization = specialization;
            this.GPA = GPA;
        }
        public void setStudent_level(string student_level)
        {
            this.student_level = student_level;
        }
        public string getStudent_level()
        {
            return this.student_level;
        }
        public void setSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
        public string getSpecialization()
        {
            return this.specialization;
        }
        public void setGPA(int GPA)
        {
            this.GPA = GPA;
        }
        public int getGPA()
        {
            return this.GPA;
        }
    }
}