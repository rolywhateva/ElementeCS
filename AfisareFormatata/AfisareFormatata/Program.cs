using System;


    class Program
    {
        static void Main(string[] args)
        {
        float d = 3.2f;
        double s = -5.55d;
        Console.WriteLine("{0} {1}", d, s);
        Console.WriteLine("{1} {0}", d, s);
        Console.WriteLine("{0} {0}", d);
        //Console.WriteLine("{0} {1}", d); Eroare!
        Console.WriteLine("{0:f11}", -3.12345f);
        Console.WriteLine("{0:f11}", 323.124453f);
            Console.WriteLine("Hello World!");
        Console.WriteLine("d = {0}", d);

        float e = 3.2e+3f;
        Console.WriteLine("{0:E}", d);

            Console.ReadKey();
        }
    }

