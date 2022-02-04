﻿using static System.Console;

namespace DIO
{       //Desafios de Código bootcamp GFT Start #3
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
        
        static void Main(string[] args)
        {
            
           
           
           
        }
    }
}