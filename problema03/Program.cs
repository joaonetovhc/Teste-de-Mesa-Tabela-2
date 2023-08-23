using System;
class Problema03{
    static void Main(){

        double valorPresente = 0;
        double taxaJuros = 0;
        double periodo = 0;
        double rendimentoFinal = 0;
        
        Console.Write("Qual o valor a ser investido?\n➯ ");
        valorPresente = double.Parse(Console.ReadLine()); 

        Console.Write("\nQual a Taxa de Juros?\n➯ ");
        taxaJuros = double.Parse(Console.ReadLine()) / 100;

        Console.Write("\nQual o periodo de tempo em meses?\n➯ ");
        periodo = int.Parse(Console.ReadLine()); 

        rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), periodo);

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine($"↓ Rendimento final apos {periodo} meses ↓");
        Console.WriteLine($" {rendimentoFinal.ToString("C")}");
        Console.WriteLine("----------------------------------------");
    }
}
