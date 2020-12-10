using System;
namespace lab_44_2 {
    class B3 : B {
        public B3(int age, string name, int salary) : base (age, name, salary) {}
        public override void DisplaySalary() {
            Console.WriteLine($"Salary is {this.Salary}");
        }
    }
}