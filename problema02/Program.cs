using System;
class Problema02{
    static void Main(){

        double valorPresente = 3800;
        double taxaJuros = 1.25 /100;
        double anos = 2 * 6;
        double meses = 1;
        double rendimentoFinal = 0;

        /*rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses);
        Console.WriteLine($" {rendimentoFinal.ToString("C")}");*/

        while(meses <= 6){
            rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses);
            Console.Write($" |Rendimento do Mes:{meses}| ");   
            Console.Write($"⇢ |{rendimentoFinal.ToString("C")}|\n");
          
            meses++;

        }
    }
}