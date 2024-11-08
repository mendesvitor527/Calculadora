using System;
using System.Xml.Serialization;

namespace Calculator{
    class Program{
        static void Main(string[] args){
            
            Menu();
            
        }

        static void Menu(){
            
            Console.Clear();

            Console.WriteLine("Qual função da Calculadora deseja utilizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("#######################");
            Console.WriteLine("Selecione uma opção: ");
            short funcaoCalculadora = short.Parse(Console.ReadLine());

            switch(funcaoCalculadora) {
                case 1: Soma(); break;
                case 2: Divisao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;

            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtracao é {resultado}");
            Console.ReadKey();
            Menu();
        }   

        static void Divisao(){

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1/valor2;

            Console.WriteLine($"O resultado é da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicacao é {resultado}");
            Console.ReadKey();
            Menu();
        }    

    }
}


