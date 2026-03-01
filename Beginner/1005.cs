using System; 

class URI {

    static void Main(string[] args) { 

    double A = Convert.ToDouble(Console.ReadLine());
    double B = Convert.ToDouble(Console.ReadLine());
    
    double MEDIA = (A*3.5 + B*7.5) / 11;
    
    Console.WriteLine($"MEDIA = {MEDIA:F5}");

    }

}