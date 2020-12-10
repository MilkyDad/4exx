using System;
using System.Drawing;

namespace lab_44_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter key:");
            string key = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Int32.Parse(Console.ReadLine());
            AppLicense license = new AppLicense();
            switch(key) {
                case "proKey":
                    license.AllowPro();
                    ProLicense NewProUser = new ProLicense(name, age);
                    NewProUser.can_i_drink();
                    break;
                case "free":
                    license.AllowCommon();
                    FreeLicense NewFreeUser = new FreeLicense(name, age);
                    NewFreeUser.can_i_drink();
                    break;
                case "demo":
                    license.AllowTrial();
                    Trial NewTrialUser = new Trial(name, age);
                    NewTrialUser.can_i_drink();
                    break;
                default:
                    Console.WriteLine("Something's went wrong.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
