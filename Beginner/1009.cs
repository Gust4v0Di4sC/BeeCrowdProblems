using System; 

// input ->  sellers name , fixed salary, total salary withbonus : SELLERNAME, FIXEDSALARY , TOTALSALARY
// process -> calculo do salario total com 15% sobre cada venda :  FINALSALARY =  (TOTALSALARY * 15/100)  + FIXEDSALARY 
// output ->  salario total CONSOLE.WRITELINE(TOTAL = R$ {FINALSALARY:F2})

class URI {

    static void Main(string[] args) { 

        string SELLERNAME = Console.ReadLine();
        double FIXEDSALARY = Convert.ToDouble(Console.ReadLine());
        double TOTALSALARY = Convert.ToDouble(Console.ReadLine());

        double FINALSALARY = (TOTALSALARY * 15/100) + FIXEDSALARY;

        Console.WriteLine($"TOTAL = R$ {FINALSALARY:F2}");

    }

}