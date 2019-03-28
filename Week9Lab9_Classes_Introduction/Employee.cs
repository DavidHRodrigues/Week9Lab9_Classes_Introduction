using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab9_Classes_Introduction
{
    /*
  # Author VK 

  # This class represents a blueprint of an employee with four attributes and two
  # methods
       * 
  */
    class Employee

    {
        //  attributes
        private string _gender;
        private string _name;
        private int _employeeNumber;
        private string _nationality;
        private int _hourlyRate;

        // static variable belong to class, no individual object has this
        public static int lastEmployeeNumber;

        // Name property used to get and set the name attribute of an object
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // Nationality property used to get and set the name attribute of an object
        public string Nationality
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
            }
        }

        // Gender property used to get and set the gender attribute of an object
        public string Gender
        {
            get
            {
                if (_gender == "Male" || _gender == "female")
                {
                    return _gender;
                }
                else
                {
                    _gender = "Unknown";
                    return _gender;
                }
                
            }
            set
            {
                _gender = value;
            }
        }

        // HourlyRate property used to get and set the hourly rate attribute of an object
        // here i am using an auto-implemented property
        // auto-implemented properties make property-declaration more concise when no
        // additionallogic is required in the property accessors. When you declare a 
        // property as shown in the following example, the compiler creates a private, 
        // anonymous backing field that can only be accessed through the property's get and
        // set accessors.
        public int HourlyRate
        {


            get
            {
                return _hourlyRate;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _hourlyRate = value;
                }
                else
                {
                    _hourlyRate = 50;
                }

            }
        }
        // EmployeeNumber property used to get and set the employee number attribute of an object
        public int EmployeeNumber
        {
            get
            {
                return _employeeNumber;
            }
            set
            {
                _employeeNumber = value;
            }

        }

        // Default construct
        public Employee()
        {
            lastEmployeeNumber++; // increment the static variable by 1
            EmployeeNumber = lastEmployeeNumber; // assign to the employee number attribute
        }


        //parameterised constructor
        public Employee(string n, string b, int p, string o)
        {
            Name = n;
            Gender = b;
            Nationality = o;
            HourlyRate = p;

            lastEmployeeNumber++;  // increment the static variable by 1
            EmployeeNumber = lastEmployeeNumber; // assign to the employee number attribute

        }
        // Method tp print the attributes of an object
        public override string ToString()
        {
            return "Name: " + Name + " Gender : " + Gender + " Nationality : " + Nationality + " Rate : " + HourlyRate + " Employee # : " + EmployeeNumber;
        }

        // a=Method to calculate an employees pay, employees work 40 hours
        public virtual double CalcPay()
        {
            return 40 * HourlyRate;

        }
    }

}
