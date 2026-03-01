using System; 
using System.Globalization;

// input -> three floating points values  ABC
// process ->  calculate areas of : triangle, circle, trapezium , square and rectangle
// output -> TRIANGULO : valueTRIANGLE, CIRCULO: valueCircle ,TRAPEZIO: valueTrapezium ,QUADRADO: valueSquare,RETANGULO: valueRect

/// <summary>
///  area triangle = A * C / 2
///  area circle =  3.14159 * C
///  area trapezium =  A+B * C / 2
///  area square =  B * B
///  area rectangle = A * B
/// </summary>

class URI {

    static void Main(string[] args) { 

        var LINEVALUES = Console.ReadLine().Split(' ');
        (double VALUEA, double VALUEB, double VALUEC) VALUES = (
            double.Parse(LINEVALUES[0], CultureInfo.InvariantCulture),
            double.Parse(LINEVALUES[1], CultureInfo.InvariantCulture),
            double.Parse(LINEVALUES[2], CultureInfo.InvariantCulture)
        );

        double TRIANGLE = (VALUES.VALUEA * VALUES.VALUEC) / 2;
        double CIRCLE = 3.14159 * Math.Pow(VALUES.VALUEC,2);
        double TRAPEZIUM = (VALUES.VALUEA + VALUES.VALUEB) * VALUES.VALUEC / 2;
        double SQUARE = VALUES.VALUEB * VALUES.VALUEB;
        double RECTANGLE = VALUES.VALUEA * VALUES.VALUEB;

        Console.WriteLine($"TRIANGULO: {TRIANGLE:F3}");
        Console.WriteLine($"CIRCULO: {CIRCLE:F3}");
        Console.WriteLine($"TRAPEZIO: {TRAPEZIUM:F3}");
        Console.WriteLine($"QUADRADO: {SQUARE:F3}");
        Console.WriteLine($"RETANGULO: {RECTANGLE:F3}");

    }

}