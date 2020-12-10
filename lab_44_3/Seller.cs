using System;
using System.Diagnostics;
namespace lab_44_3 {
    class Seller : Worker {
        private string _goodsType;
        public string TypeOfGoods {get {return _goodsType;} set { _goodsType = value;}}
        public Seller() {}
        public Seller(string name, int age, int salary, string goods) : base(name, age, salary) {
            this.TypeOfGoods = goods;
        }
        public override void About() {
            Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}\nType of goods: {this.TypeOfGoods}\n");
            Debug.WriteLine($"Builder\nName: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}\nType of goods: {this.TypeOfGoods}");
        }
    }
}