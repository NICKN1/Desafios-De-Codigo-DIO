using System;
using static System.Console;

namespace DIO
{       //Desafios de Código bootcamp GFT Start #3 e #4
    class Program
    {
        static void desafio1(){
           /*===============DESAFIO 1===============
           Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre
           iferença do produto de A e B pelo produto de C e D segundo a fórmula: 
           DIFERENCA = (A * B - C * D).*/ 
          int A = int.Parse(ReadLine());
          int B = int.Parse(ReadLine());
          int C = int.Parse(ReadLine());
          int D = int.Parse(ReadLine());
          int DIFERENCA = 0;
         
            DIFERENCA = (A * B - C * D);
            WriteLine($"DIFERENCA = {DIFERENCA}");
            ReadKey();
           
           
        }

        
        static void desafio2(){
        /*===============DESAFIO 2===============
        Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma 
        mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores 
        lidos são múltiplos entre si.
        */
            string[] valores = ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0 ) {
                WriteLine("Sao Multiplos");
            }
            else {
                WriteLine("Nao sao Multiplos");
            }
        }
 
 
        static void desafio3(){
        /*===============DESAFIO 3===============
        Neste problema, deve-se ler o código de uma peça 1, o número 
        de peças 1, o valor unitário de cada peça 1, o código de uma peça 2,    
        o número de peças 2 e o valor unitário de cada peça 2. Após, calcule      
        e mostre o valor a ser pago.*/    
        string[] input;

	      input = ReadLine().Split(' ');
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2]);

 	      input = ReadLine().Split(' ');
        int cod2 = int.Parse(input[0]);
	      int n2  = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        double total = (valor1 * n1) + (valor2 * n2);
        WriteLine("VALOR A PAGAR: R$ {0:F2}", total);     
        }
        

        static void desafio4(){
        /*===============DESAFIO 4===============
        Faça a leitura de um valor inteiro. Em seguida, calcule o menor 
        número de notas possíveis (cédulas) onde o valor pode ser decomposto. 
        As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. 
        Na sequência mostre o valor lido e a relação de notas necessárias.*/

        int n, quociente, resto;

            n = int.Parse(ReadLine());
            WriteLine(n);

            resto = n;
    
            quociente = resto / 100;
            WriteLine($"{quociente} nota(s) de R$ 100,00");
            resto = resto % 100;
            
            quociente = resto / 50;
            WriteLine($"{quociente} nota(s) de R$ 50,00");
            resto = resto % 50;
            
            quociente = resto / 20;
            WriteLine($"{quociente} nota(s) de R$ 20,00");
            resto = resto % 20;
            
            quociente = resto / 10;
            WriteLine($"{quociente} nota(s) de R$ 10,00");
            resto = resto % 10;
            
            quociente = resto / 5;
            WriteLine($"{quociente} nota(s) de R$ 5,00");
            resto = resto % 5;
            
            quociente = resto / 2;
            WriteLine($"{quociente} nota(s) de R$ 2,00");
            resto = resto % 2;

            quociente = resto / 1;
            WriteLine($"{quociente} nota(s) de R$ 1,00");
            resto = resto % 1;
        }


        static void desfio5(){
            /*===============DESAFIO 5===============
            Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um
             triângulo. Em caso positivo, calcule o perímetro do triângulo e 
             apresente a mensagem:
                Perimetro = XX.X
            Em caso negativo, calcule a área do trapézio que tem A e B como base e C como 
            altura, mostrando a mensagem
                Area = XX.X
            */
            double a, b, c;
            string[] valor = ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            double total = 0.0;
            
            total = (a + b) * c / 2;
            if(total % 2 == 0){
                WriteLine($"Area = {total.ToString("F1")}");

            }
            else{
              total = a + b + c;
              WriteLine($"Perimetro = {total.ToString("F1")}");
            }
        }
        
        
        static void desafio6(){
            /*===============DESAFIO 5===============
            O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D 
            for igual a 0. Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive
             ele mesmo , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o 
             resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a 
             saída deve ser 80, que é a soma de 12+14+16+18+20.
            */
            int entrada = -1;
           while (entrada != 0){
                entrada = int.Parse(ReadLine());
                int total = 0;
                int soma = entrada;

                if (entrada == 0){
                    break;
                }
                   if(entrada % 2 == 0){
                       soma = entrada + 2;
                       for (int i = 0; i < 4; i++)  {
                        total = total + soma;
                        soma = soma + 2;
                         
                       }
                   }
                   
                   else{
                       soma = entrada + 3;
                       for (int i = 0; i < 4; i++)  {
                        total = total + soma;
                        soma = soma + 2;
                       }
                       entrada = entrada + 1;
                   }   
                                        
             WriteLine($"{total + entrada}");  
        }
        static void Main(string[] args)
        {
  
               
         }
        
        }
    }
}
