using System;
using System.Globalization;


// input -> two products with codeproduct , units, priceunit : PRODUCTCODE, UNITS, PRICEUNIT
// process -> calcular o valor a ser pago pelos 2 produtos : FINALVALUE =  units1 * priceunit + units2 * price 
// output -> total a ser pago console.writeline(VALOR A PAGAR: {FINALVALUE})

class URI {

    static void Main(string[] args) { 

        var LINEONE = Console.ReadLine().Split(' ');
        (int productCode, int units, double priceUnit) productOne = (
            int.Parse(LINEONE[0]),
            int.Parse(LINEONE[1]),
            double.Parse(LINEONE[2], CultureInfo.InvariantCulture)
        );

        var LINETWO = Console.ReadLine().Split(' ');
        (int productCodeTwo, int unitsTwo, double priceUnitTwo) productTwo = (
            int.Parse(LINETWO[0]),
            int.Parse(LINETWO[1]),
            double.Parse(LINETWO[2], CultureInfo.InvariantCulture)
        );


        double FINALVALUE = (productOne.units * productOne.priceUnit) + (productTwo.unitsTwo * productTwo.priceUnitTwo);

        Console.WriteLine($"VALOR A PAGAR: R$ {FINALVALUE:F2}");

    }

}