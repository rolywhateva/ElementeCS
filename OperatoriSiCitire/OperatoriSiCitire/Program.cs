using System;



    class Program
    {
        static void Main()
        {
        //Operatorii sunt ca  in C++!!!
        int a = 2 + 3;
        int b = 3 - 5;
        int c = 18 / 3;
        int d = 18 + 3;
        int x = a % b;

        bool ex = true || false;
        bool what = true && true;
        bool y = !true;

        Console.WriteLine(3 < 4);
        Console.WriteLine(3 <= 4);
        Console.WriteLine(3 > 4);
        Console.WriteLine(3 == 4);
        Console.WriteLine(3 != 4);
        Console.WriteLine();

        int p, q;
        p = int.Parse(Console.ReadLine());
        q = int.Parse(Console.ReadLine());
        Console.WriteLine(p + q);
        Console.WriteLine(p - q);
        Console.WriteLine(p / q);
        Console.WriteLine(p * q);
        Console.WriteLine(p % q);



       


            Console.ReadKey();

        }
    }

