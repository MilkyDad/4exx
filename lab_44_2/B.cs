using System;

namespace lab_44_2 {
    class B {
        private int _age;
        private string _name;
        private int _salary;
        public int Age {get {return _age;} set {_age = value;}}
        public string Name {get {return _name;} set {_name = value;}}
        public int Salary {get {return _salary;} set {_salary = value;}}
        public B() {}
        public B(int age, string name, int salary) {
            this.Age = age;
            this.Name = name;
            this.Salary = salary;
        }
        public virtual void DisplayAge() {
            Console.WriteLine($"{this.Age}");
        }
        public virtual void DisplayName() {
            Console.WriteLine($"{this.Name}");
        }
        public virtual void DisplaySalary() {
            Console.WriteLine($"{this.Salary}");
        }
    }
}