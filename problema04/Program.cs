using System;
class Problema04{

    static void Main(){

        double valorPresente = 2000;
        double taxaJuros = 2.0 / 100;
        double meses = 1;
        double rendimentoFinal = 0;
        double saque = 0;
        double saldo = 0;
        double meses2 = 1;

            while(meses <= 5){

            rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses);
            Console.Write($" |Rendimento do Mes:{meses}| ");
            Console.Write($" ⇢  |{rendimentoFinal.ToString("C")}|\n");   
            meses++;
            
            saldo = rendimentoFinal;

            if(meses == 6 ){
                
                Console.Write("-----------------------------------------------|");
                Console.Write("\nQuer fazer um resgate de quanto?\n➯ R$");
                saque = double.Parse(Console.ReadLine());
                saldo = saldo - saque;
                valorPresente = saldo;

                Console.WriteLine("-----------------------------------------------|");
                Console.WriteLine($"Saldo pós resgate ➯ {valorPresente.ToString("C")}");
                Console.WriteLine("-----------------------------------------------|");
                rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses);

                // valorPresente ta pegando o valor do saldo

                while(meses2 <= 3){
                       
                    rendimentoFinal = valorPresente * Math.Pow((1 + taxaJuros), meses2);
                    Console.Write($" |Saldo de rendimento do Mes:{meses2}| ");
                    Console.Write($"⇢  |{rendimentoFinal.ToString("C")}|\n");
                    meses2++;
                
                }
            }
        }
                    Console.WriteLine("-----------------------------------------------|");
    }
}

