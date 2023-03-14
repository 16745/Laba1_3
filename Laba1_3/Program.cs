using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using Laba1_3;

class Program
{
    static void Main(string[] args)
    {
        //Введення даних
        string IntValue1;
        Ryadky r1 = new Ryadky();
        Ryadky r2 = new Ryadky();
        while(r1.check())
        {
            Console.Write("Введiть перший рядок(0-9):");
            r1.ryadok = Console.ReadLine();
        }
        while (r2.check())
        {
            Console.Write("Введiть другий рядок(0-9):");
            r2.ryadok = Console.ReadLine();
        }
        Console.Write("Введiть значення типу int:");
        IntValue1 = Console.ReadLine();
        int IntValue2 = Convert.ToInt32(IntValue1);

        //Перевантаження операторів

        //String * int
        Ryadky r6 = r1 * IntValue2;

        //int * String
        Ryadky r7 = IntValue2 * r1;

        //String+String
        Ryadky r3 = r1 + r2;

        //String == String
        bool r4 = r1 == r2;

        //String--
        Ryadky r5 = --r1;

        //Виведення

        //String * int
        Console.WriteLine("_______________");
        Console.WriteLine("String * int");
        Console.WriteLine("Ryadky r6 = r1 * intValue");
        Console.WriteLine("r6.ryadok = " + r6.ryadok);

        //int * String
        Console.WriteLine("_______________");
        Console.WriteLine("int * String");
        Console.WriteLine("Ryadky r7 = intValue * r1");
        Console.WriteLine("r7.ryadok = " + r7.ryadok);

        //String+String
        Console.WriteLine("_______________");
        Console.WriteLine("String + String"); 
        Console.WriteLine("Ryadky r3 = r1+r2");
        Console.WriteLine("r3.ryadok = "+r3.ryadok);

        //String == String
        Console.WriteLine("_______________");
        Console.WriteLine("String == String");
        Console.WriteLine("r4 = r1==r2");
        Console.WriteLine("r4 = "+r4);

        //String--
        Console.WriteLine("_______________");
        Console.WriteLine("String--");
        Console.WriteLine("Ryadky r5 = --r1");
        Console.WriteLine("r5.ryadok = " + r5.ryadok);

        //Повернути якщо будь-який із закритих полів класу не дорівнює 0
        Console.WriteLine("_______________");
        Console.WriteLine("Повернути true якщо будь-який iз закритих полiв класу не дорiвнює 0");
        if (r1) { Console.WriteLine(true);}
        else Console.WriteLine(false);
    }
}
