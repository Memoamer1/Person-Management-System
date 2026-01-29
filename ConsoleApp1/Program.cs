using System;
using ConsoleApp1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salaried_Employee emp1 = new salaried_Employee("Alice", 30, "123 Main St", true, 60000, 2, "Manager", 7000, 3000);
            Houerly_Employee emp2 = new Houerly_Employee("Bob", 25, "456 Elm St", false, 40000, 1, "Staff", 45, 25);
            student stud1 = new student("Charlie", 20, "789 Oak St", true, "Undergraduate", "Engineering", 3);
            Console.WriteLine($"Salaried Employee: {emp1.getSalary()}, Bonus: {emp1.getBonus()}, Deduction: {emp1.getDeduction()}");
            Console.WriteLine($"Hourly Employee: {emp2.getSalary()}, Hours Worked: {emp2.getHours_worked()}, Hourly Rate: {emp2.getHourly_rate()}");
            Console.WriteLine($"Student: {stud1.getStudent_level()}, Specialization: {stud1.getSpecialization()}, GPA: {stud1.getGPA()}");
        }
    }
}
