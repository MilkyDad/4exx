using System;
using System.Diagnostics;
namespace lab_44_3 {
    class Builder : Worker {
        private string _workingPlace;
        private int _workingTime;
        private string _rank;
        public string workingPlace {get {return _workingPlace;} set { _workingPlace = value;}}
        public int workingTime {get {return _workingTime;} set {_workingTime = value;}}
        public string Rank { get { return _rank;} set {_rank = value;}}
        public Builder() {}
        public Builder(string name, int age, int salary, string workingplace, int workingtime, string rank) : base(name, age, salary) {
            this.workingPlace = workingplace;
            this.workingTime = workingtime;
            this.Rank = rank;
        }
        public override void About() {
            Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}\nWorking hours: {this.workingTime}\nWorking place: {this.workingPlace}\nRank: {this.Rank}\n");
            Debug.WriteLine($"Builder\nName: {this.Name}\nAge: {this.Age}\nSalary: {this.Salary}\nWorking hours: {this.workingTime}\nWorking place: {this.workingPlace}\nRank: {this.Rank}");
        }
    }
}