using System; 

// input ->  valor do raio em ponto flutuante double RadiusSPHERE
// process -> calculo do volume de uma esfera VOLUME = (4/3) * 3.14159 * RadiusSphere.MathPow(3)
// output -> volume da esfera

class URI {

    static void Main(string[] args) { 

        double RADIUSSPHERE = Convert.ToDouble(Console.ReadLine());

        double VOLUME = (4/3.0) * 3.14159 * Math.Pow(RADIUSSPHERE, 3);

        Console.WriteLine($"VOLUME = {VOLUME:F3}");
    }

}