using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3.Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates using class Employee.");

            try
            {
                string firstName, surName, patronymicName, position = null;
                DateTime bdate, edate;
                Console.WriteLine("Enter Surname: ");
                surName = Console.ReadLine();
                Console.WriteLine("Enter First Name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Patronymic: ");
                patronymicName = Console.ReadLine();
                Console.WriteLine("Enter Birth Date: ");
                bdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter position in the company: ");
                position = Console.ReadLine();
                Console.WriteLine("Enter Employement Date: ");
                edate = DateTime.Parse(Console.ReadLine());

                Employee employee = new Employee(firstName, surName, patronymicName, bdate, position, edate);

                Console.WriteLine($"{Environment.NewLine}" +
                    $"Employee Information:{Environment.NewLine}" +
                    $"Surname: {employee.SurName}{Environment.NewLine}" +
                    $"Name: {employee.FirstName}{Environment.NewLine}" +
                    $"Patronymic: {employee.Patronymic}{Environment.NewLine}" +
                    $"Birthday: {employee.BirthDay.Day}.{employee.BirthDay.Month}{Environment.NewLine}" +
                    $"Age: {employee.Age}{Environment.NewLine}" +
                    $"Position: {employee.Position}{Environment.NewLine}" +
                    $"Experience: {employee.WorkExperience}{Environment.NewLine}");
                }
            catch
            {
                Console.WriteLine("The wrong input data! Let's try again!");
            }
        }
    }
}
