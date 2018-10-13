using System;
/* Orice tip de date este un obiect(deci au proprietati si
 * functii) 
 * Tipurile coincid cu cele din C++
 * 
 * 
 * */


    class Program
    {
        static void Main(string[] args)
        {
        // int - numere intregi
        int a = 3;

        //float - numere reale, constantele de tip float
        // au  dupa ele litera 'f', care  le identifica.
        float b = 3.5f;

        //double - numere reale, doar cu precizie mai buna oarecum
        //au dupa ele litera 'd', care le identifica.
        //valorile reale sunt double intr-un mod implicit.
        double s = 3.5;

        //decimal -  acestea pot fi considerate  numere intregi
        //sau reale, dupa nevoie, au o precizie mult mai buna
        // si sunt folosite pentru calcule scurte, dar pentru care
        // trebuie sa avem un rezultat exact.
        decimal d =3;

        //uint-intreg pozitiv
        uint x = 3;

        //long - intreg foarte mare 
        long e = 4546657;

        //ulong - intreg pozitiv foarte mare;

        ulong q = 4534534534545;


        //char - caractere, care incep si se terminca cu 's'.

        char c = 's';


         // bool - valori logice, adevarat( true sau false)
        bool f = true;
        //Fiecare tip de date are o proprietate care memoreaza
        // valoarea minima(si una care o are pe cea maxima)
        Console.WriteLine("int : "+int.MinValue + " " + int.MaxValue);
        Console.WriteLine("uint : " + uint.MinValue + " " + uint.MaxValue);

        Console.WriteLine("long:" + long.MinValue + " " + long.MaxValue);
        Console.WriteLine("ulong:" + ulong.MinValue + " " + ulong.MaxValue);

        Console.WriteLine("float:" + float.MinValue + " " + long.MaxValue);
        Console.WriteLine("double:" + double.MinValue + "  " + double.MaxValue);
        //Pana si constantele!

        Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
        Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
        Console.WriteLine("12.ToString() = {0}", 12.ToString());
        Console.WriteLine("12.GetType() = {0}", 12.GetType());





        Console.ReadKey();
        }
    }

