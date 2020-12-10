using System;

namespace lab_44_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B worker1 = new B(18, "Kozlov", 13000);
            B worker2 = new B(19, "Artem", 130400);
            B worker3 = new B(20, "Lebedev", 130000);
            A a1 = new A(worker1, worker2, worker3);
            a1.About();
            A a2 = new A(worker1, worker3);
            worker1.DisplayAge();

            B1 bb1 = new B1(worker1.Age, worker1.Name, worker1.Salary);
            bb1.DisplayAge();

            B2 bb2 = new B2(worker2.Age, worker2.Name, worker2.Salary);
            bb2.DisplayName();
        }
    }
}
