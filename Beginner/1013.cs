using System;
using System.Globalization;

// input : three integer values : 3, 11, 20
// process : maiorvalor = (a+b+abs(a-b)) / 2 
// output : the greatest value :  Console.WriteLine("maiorvalor eh o maior") 

class URI
{

    static void Main(string[] args)
    {

       var LINEVALUES = Console.ReadLine().Split(' ');
        (int VALUEA, int VALUEB, int VALUEC) VALUES = (
            Int32.Parse(LINEVALUES[0], CultureInfo.InvariantCulture),
            Int32.Parse(LINEVALUES[1], CultureInfo.InvariantCulture),
            Int32.Parse(LINEVALUES[2], CultureInfo.InvariantCulture)
        );

        int MAIORAB = (VALUES.VALUEA + VALUES.VALUEB + Math.Abs(VALUES.VALUEA - VALUES.VALUEB)) / 2;

        int MAIORABC = (MAIORAB + VALUES.VALUEC + Math.Abs(MAIORAB - VALUES.VALUEC)) / 2;

        Console.WriteLine($"{MAIORABC} eh o maior");

    }

}