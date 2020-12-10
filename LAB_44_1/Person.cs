using System;
using System.Diagnostics;

namespace фыв {
    class Person {
        private string _name;
        private int _age;
        public string Name {
            get{return _name;} 
            set{_name = value;}
        }
        public int Age {
            get{return _age;}
            set{_age = value;}
        }
        public Person() {}
        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
        public virtual void getInfo() {
            // Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\n");
            Debug.WriteLine($"Name: {this.Name}\nAge: {this.Age}\n");
        }
    }
}