using System;
namespace lab_44_4 {
    class AppLicense {
        public void AllowTrial() {
            Console.WriteLine("Trial mode");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Free version");
        }
        public void AllowPro()
        {
            Console.WriteLine("Pro mode");
        }
        private int _age;
        private string _name;
        public int Age {get {return _age;} set { _age = value;}}
        public string Name {get {return _name;} set {_name = value;}}
        public AppLicense() {}
        public AppLicense(string name, int age) {
            this.Age = age;
            this.Name = name;
        }
        public virtual void can_i_drink() {
            if(this.Age >= 18) 
            {
                Console.WriteLine($"You can drink, {this.Name}");
                Console.WriteLine("List to try: Vodka, Whiskey, Brandy, Vermouth, Cognac, Beer, Port wine, Rum, Gin, Cider");
            }
            else {
                Console.WriteLine($"You can't drink, {this.Name}");
            }
        }
    }
}