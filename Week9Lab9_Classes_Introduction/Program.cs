using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab9_Classes_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // code to test our classes
            //
            Employee employee = new Employee();  // create an employee using the default constructor
            Console.WriteLine(employee.ToString()); // print this employees attributes using the ToString()method of the employee object
            Console.WriteLine("Pay = {0}", employee.CalcPay()); // call the CalcPay meth of the employee

            employee.Name = "John";  // set the attributes of the employee using Setter
            employee.Gender = "Male";
            employee.HourlyRate = 100000;
            employee.Nationality = "Portuguese";

            Console.WriteLine(employee.ToString());  // print this employees attributes using the ToString()method of the employee object

            Console.WriteLine("Pay = {0}", employee.CalcPay());

            employee = new Employee("sarah", "female", 15, "Portuguese"); // create a new employee using parameterised constructor
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Pay = {0}", employee.CalcPay());


            // create an array of employees
            Employee[] Employees = new Employee[2];

            Employees[0] = new Employee("Mary", "female", 500000,"Spanish");
            Employees[1] = new Employee("Ann", "female", 25, "Latvian");


            Console.WriteLine("\n  Array of 2 employees    \n");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Employees[i].ToString());
                Console.WriteLine("Your pay = " + Employees[i].CalcPay());

            }

        }

    }
}
