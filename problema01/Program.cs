using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

class Problema01{
    static void Main(){

        double valorPresente = 1000;
        double taxaJuros = 5.30 /100;
        double anos = 2 * 12;
        double meses = 6;
        double rendimentoFinal = 0;
    
        rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses);
        Console.WriteLine("\nVocê terá os seguintes rendimentos, ");
        Console.WriteLine($"com {valorPresente.ToString("C")} investidos.");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(" Rendimento final após 6 meses ");
        Console.WriteLine($" ➯ {rendimentoFinal.ToString("C")}");
        Console.WriteLine("----------------------------------");
       
        rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), anos);
        Console.WriteLine(" Rendimento final após 2 Anos ");
        Console.WriteLine($" ➯ {rendimentoFinal.ToString("C")}");
        Console.WriteLine("----------------------------------");
    
    }

}