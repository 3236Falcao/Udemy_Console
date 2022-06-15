using Servico;
using System;
using System.Linq;
using System.Threading;

namespace Udemy_Console
{
    public class Program
    {
        //private readonly CalculoService _CalculoService;

        //public Program(CalculoService calculoService)
        //{
        //    _CalculoService = calculoService;
        //}

        public static void Main()
        {            
            var MyClass = new Program();
            Console.WriteLine("Bem vindo Dev!");
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("__________________________________________");            
            Console.WriteLine("Olá " + nome + ", Vamos jogar?");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int decisaoDeIniciar = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");

            if (decisaoDeIniciar == 1)
            {                
                Console.WriteLine("Que legal!");
                Thread.Sleep(1000);
                MyClass.ChamarMetodos();                
            }
            else
            {
                Console.WriteLine("Que pena , então vamos deixar para a próxima.");
                Environment.Exit(decisaoDeIniciar);
            }            
        }

        public void ChamarMetodos()
        {
            Console.Clear();
            int valor = 0;
            int recebeOpcao = 0;
            var MyClass = new Program();
          
            Console.WriteLine("Digite dois numeros");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou " + valor1 + " e " + valor2);
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            recebeOpcao = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");

            do
            {             
                if (recebeOpcao == 1)
                {
                    valor = MyClass.SomarNumeros(valor1, valor2);
                    Console.WriteLine("A soma de " + valor1 + " + " + valor2 + " é igual a " + (valor));
                    
                }
                if (recebeOpcao == 2)
                {
                    valor = MyClass.SubtrairNumeros(valor1, valor2);
                    Console.WriteLine("A subtração de " + valor1 + " - " + valor2 + " é igual a " + (valor));
                }
                if (recebeOpcao == 3)
                {
                    valor = MyClass.MultiplicarNumeros(valor1, valor2);
                    Console.WriteLine("A multiplicação de " + valor1 + " x " + valor2 + " é igual a " + (valor)); 
                }
                if (recebeOpcao == 4)
                {
                    valor = MyClass.DividirNumeros(valor1, valor2);                    
                    Console.WriteLine("A divisão de " + valor1 + " / " + valor2 + " é igual a " + (valor));                                    
                   
                }
                if (recebeOpcao <= 0 || recebeOpcao > 4)
                {
                    Console.WriteLine(recebeOpcao + " é uma opção inválida!");                 
                }
                
                Console.WriteLine("__________________________________________");              

                Console.WriteLine("Vamos continuar brincando?");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int decisaoDeContinuar = int.Parse(Console.ReadLine());

                if (decisaoDeContinuar == 1)
                {
                    Console.WriteLine("Que legal!");
                    Console.WriteLine("__________________________________________");

                    //Sleep: bloqueia o thread principal por 1segundo
                    Thread.Sleep(1000);
                    ChamarMetodos();
                }
                else
                {
                    Console.WriteLine("Que pena , então vamos deixar para a próxima.");

                    //Environment: Encerra o processo "decisaoDeContinuar" e retorna um código de saída para o sistema operacional.
                    Environment.Exit(decisaoDeContinuar);
                }                               
                ChamarMetodos();

            } while (recebeOpcao >= 1 || recebeOpcao <= 4);            
        }

        public int SomarNumeros(int numero1, int numero2)
        {
            var resultadoSoma = (numero1 + numero2);
            return resultadoSoma;
        }

        public int SubtrairNumeros(int numero1, int numero2)
        {
            var resultadoSoma = (numero1 - numero2);
            return resultadoSoma;
        }

        public int MultiplicarNumeros(int numero1, int numero2)
        {
            var resultadoSoma = (numero1 * numero2);
            return resultadoSoma;
        }

        public int DividirNumeros(int numero1, int numero2)
        {
            var resultadoSoma = (numero1 / numero2);
            return resultadoSoma;
        }
        
    }
}
