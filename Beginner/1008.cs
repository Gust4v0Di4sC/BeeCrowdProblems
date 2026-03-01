using System;
using Microsoft.Win32.SafeHandles;



class URI {

    static void Main(string[] args) { 

        int NUMBER = Convert.ToInt32(Console.ReadLine());
        int HOURS = Convert.ToInt32(Console.ReadLine());
        double AMOUNT = Convert.ToDouble(Console.ReadLine());

        double SALARY = HOURS * AMOUNT;


        Console.WriteLine($"NUMBER = {NUMBER}");
        Console.WriteLine($"SALARY = U$ {SALARY:F2}");

    }

}