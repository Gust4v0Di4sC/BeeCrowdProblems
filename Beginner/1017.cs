using System; 

// input : spenttime , avg speed (km/h)
// process : litersspent = avgspeed * spenttime / 12 (km/l)
// output : Console.WriteLine($"{litersspent:F3}")

class URI {

    static void Main(string[] args) { 

       int SPENTTIME = Int32.Parse(Console.ReadLine());
       int AVGSPEED = Int32.Parse(Console.ReadLine());

          double LITERSSPENT = Convert.ToDouble(AVGSPEED * SPENTTIME / 12);

       Console.WriteLine($"{LITERSSPENT:F3}");

    }

}