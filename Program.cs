using Servico;
using System;
using System.Linq;

namespace Udemy_Console
{
    public class Program
    {
        //private readonly CalculoService _CalculoService;

        public static void Main()
        {
            
            Console.WriteLine("Bem vindo Dev!");
            Console.WriteLine("__________________________________________");
            var MyClass = new Program();
            MyClass.ChamarMetodos();
        }

        public void  ChamarMetodos()
        {

            int valor = 0;
            int recebeOpcao = 0;
            var MyClass = new Program();

            Console.WriteLine("Digite dois numeros");
            int valor1 = Int32.Parse(Console.ReadLine());
            int valor2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou " + valor1 + " e " + valor2);
            Console.WriteLine("__________________________________________");
            
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                recebeOpcao = Int32.Parse(Console.ReadLine());

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

            }
            while (recebeOpcao <= 0 || recebeOpcao > 4);
            Console.Clear();
            ChamarMetodos();
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
