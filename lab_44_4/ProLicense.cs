using System;
namespace lab_44_4 {
    class ProLicense : AppLicense {
        public ProLicense() {}
        public ProLicense(string name, int age) : base(name, age) {}
        public override void can_i_drink()
        {
            Console.WriteLine($"Thank you for buying, {this.Name}");
            base.can_i_drink();
        }
    }
}