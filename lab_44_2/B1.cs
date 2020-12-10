using System;
namespace lab_44_2 {
    class B1 : B {
        public B1(int age, string name, int salary) : base (age, name, salary) {}
        public override void DisplayAge() {
            Console.WriteLine($"Age is {this.Age}");
        }
    }
}