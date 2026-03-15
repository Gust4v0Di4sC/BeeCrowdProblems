using System; 

// input : value of car y km
// process : distance = carykm * 2 minutes per km
// output : Console.WriteLine($"{distance} minutos") 

class URI {

    static void Main(string[] args) { 
        int CARDISTANCE = Int32.Parse(Console.ReadLine());

        int DISTANCECARS = CARDISTANCE * 2;

        Console.WriteLine($"{DISTANCECARS} minutos");
    }

}