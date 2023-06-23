/*Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura*/

class Lab1Ex3 {
    static void Main() 
    {

        int numar;

        Console.WriteLine("Introdu un numar intreg:");
            numar = int.Parse(Console.ReadLine());

        Console.WriteLine("Ultimul numar este:");

        Console.WriteLine(numar % 10);
    
    }

}

