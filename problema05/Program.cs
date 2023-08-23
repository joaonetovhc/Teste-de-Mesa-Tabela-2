using System;
class Problema05{
    static void Main(){

        double valorPresente = 3800;
        double taxaJuros = 1.25 /100;
        double anos = 2 * 12;
        double valorFuturo = 7390.61;

        valorPresente = valorFuturo/ Math.Pow((1+taxaJuros),anos); // calculo
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine($"Para obter ➯ R$7.390,61\nPrecisa investir ➯ {valorPresente.ToString("C")}");
        Console.WriteLine("----------------------------------------");
         
    }
}