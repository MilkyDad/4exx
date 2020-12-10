using System;
namespace lab_44_4 {
    class Trial : AppLicense {
        public Trial() {}
        public Trial(string name, int age) : base(name, age) {
            
        }
        public override void can_i_drink()
        {
            Console.WriteLine($"Please, {this.Name}, purchase this software to see everything");
        }
    }
}