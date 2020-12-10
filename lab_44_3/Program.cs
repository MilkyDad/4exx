using System;

namespace lab_44_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Evhen = new Worker("Evgen", 33, 10000);
            Evhen.About();

            Builder Misha = new Builder("Misha", 30, 13000, "Some spot", 6, "Captain");
            Misha.About();

            Seller Ibrahim = new Seller("Ibrahim", 30, 130000, "Medical Equipment");
            Ibrahim.About();
            Console.ReadKey();
        }
    }
}
