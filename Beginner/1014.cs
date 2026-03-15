using System; 

// input : two values , x (distance), y (spent fuel total)
// process : consumption = x / y
// output :  Console.WriteLine($"{consumption} km/l")  
class URI {

    static void Main(string[] args) { 

        int DISTANCE =  Int32.Parse(Console.ReadLine());
        double SPENTFUEL = double.Parse(Console.ReadLine());

        double CONSUMPTION = DISTANCE / SPENTFUEL;

        Console.WriteLine($"{CONSUMPTION:F3} km/l");

    }

}