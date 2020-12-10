using System;
using System.Diagnostics;
namespace lab_44_3 {
    class Worker {
        private string _name;
        private int _age;
        private int _salary;
        public string Name { get {return _name;} set {_name = value;}}
        public int Age { get { return _age;} set {_age = value;}}
        public int Salary { get { return _salary;} set {_salary = value;}}
        public Worker() {}
        public Worker(string name, int age, int salary) {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
        public virtual void About() {
            Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}\n");
            Debug.WriteLine($"Worker\nName: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}");
        } 
    }
}