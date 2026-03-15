using System; 
using System.Globalization;

// input : four values  , x and y of twopoints in the plane p1(x1,y1) p2(x2,y2)
// process : distance = Math.Sqrt(Math.Pow(x2 - x1,2) - Math.Pow(y2-y1,2));
// output : Console.WriteLine($"{distance:F4}") 

class URI {

    static void Main(string[] args) { 

        var LINEVALUESA = Console.ReadLine().Split(' ');
        (double VALUEX, double VALUEY) VALUESA = (
            double.Parse(LINEVALUESA[0], CultureInfo.InvariantCulture),
            double.Parse(LINEVALUESA[1], CultureInfo.InvariantCulture)
        );

        var LINEVALUESB = Console.ReadLine().Split(' ');
        (double VALUEX, double VALUEY) VALUESB = (
            double.Parse(LINEVALUESB[0], CultureInfo.InvariantCulture),
            double.Parse(LINEVALUESB[1], CultureInfo.InvariantCulture)
        );

        double DISTANCE = Math.Sqrt(Math.Pow(VALUESB.VALUEX - VALUESA.VALUEX, 2 ) + Math.Pow(VALUESB.VALUEY - VALUESA.VALUEY, 2));

        Console.WriteLine($"{DISTANCE:F4}");

    }

}