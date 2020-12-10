using System;
namespace lab_44_4 {
    class FreeLicense : AppLicense {
        public FreeLicense() {

        }
        public FreeLicense(string name, int age) : base(name, age) {

        }
        public override void can_i_drink()
        {
            if(this.Age >= 18) {
                Console.WriteLine($"You can, {this.Name}");
            }
            else {
                Console.WriteLine($"You can't drink, {this.Name}");
            }
        }
    }
}