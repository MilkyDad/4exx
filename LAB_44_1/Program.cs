using System;
using System.Diagnostics;

namespace фыв
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Evgen Petrovych", 54);
            person.getInfo();

            Employee employee = new Employee("Another one", 15, 300.533);
            employee.getInfo();

            Person person1 = (Person)person;
            person1.getInfo();
            
            Employee employee1 = (Employee)employee;
            employee1.getInfo();
        }
    }
}
