using System; 

class URI {

    static void Main(string[] args) { 

    double R = Convert.ToDouble(Console.ReadLine());
    
    double A = 3.14159 * Math.Pow(R,2);
    
    Console.WriteLine($"A={A:F4}");

    }

}