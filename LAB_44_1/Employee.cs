using System;
using System.Diagnostics;
namespace фыв {
    class Employee : Person {
        private double _salary;
        public double Salary {
            get {return _salary;}
            set {_salary = value;}
        }
        public Employee() : base() {

        }
        public Employee(string name, int age, double salary) : base(name, age) {
            this.Salary = salary;
        }
        public override void getInfo() {
            // Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}");
            Debug.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}");
        }
    }
}