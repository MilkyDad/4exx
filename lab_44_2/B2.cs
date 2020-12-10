using System;
namespace lab_44_2 {
    class B2 : B {
        public B2(int age, string name, int salary) : base (age, name, salary) {}
        public override void DisplayName() {
            Console.WriteLine($"Name is {this.Name}");
        }
    }
}