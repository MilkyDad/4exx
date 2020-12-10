using System;

namespace lab_44_2 {
    class A {
        B b1;
        B b2;
        B b3;
        public A() {}
        public A(B b1, B b2, B b3) {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A(B b1, B b2) : this(b1, b2, null) { }
        public void About() {
            if(b3 == null) {
                Console.WriteLine($"Name- {b1.Name}\nAge - {b1.Age}\nSalary - {b1.Salary}");
                Console.WriteLine($"Name- {b2.Name}\nAge - {b2.Age}\nSalary - {b2.Salary}");
            }
            else {
                Console.WriteLine($"Name- {b1.Name}\nAge - {b1.Age}\nSalary - {b1.Salary}");
                Console.WriteLine($"Name- {b2.Name}\nAge - {b2.Age}\nSalary - {b2.Salary}");
                Console.WriteLine($"Name- {b3.Name}\nAge - {b3.Age}\nSalary - {b3.Salary}");
            }
        }
    }
}