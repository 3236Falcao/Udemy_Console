﻿using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Udemy_Console
{    
    public class Program
    {      
        public static void Main()
        {

            List<string> listaResultados = new List<string>();
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
                Thread.Sleep(500);
                Console.Clear();
                MyClass.ChamarMetodos(listaResultados);
            }
            else
            {
                Console.WriteLine("Que pena , então vamos deixar para a próxima.");                
                Environment.Exit(decisaoDeIniciar);
            }
        }

       

        public int SomarNumeros(int numero1, int numero2)
        {
            var resultadoSoma = (numero1 + numero2);
            return resultadoSoma;
        }

        public int SubtrairNumeros(int numero1, int numero2)
        {
            var resultadoSubtracao = (numero1 - numero2);
            return resultadoSubtracao;
        }

        public int MultiplicarNumeros(int numero1, int numero2)
        {
            var resultadoMultiplicao = (numero1 * numero2);
            return resultadoMultiplicao;
        }

        public int DividirNumeros(int numero1, int numero2)
        {
            var resultadoDivisao = (numero1 / numero2);
            return resultadoDivisao;
        }

        public void ChamarMetodos(List<string> listaResultados)
        {

            Console.Clear();
            string mensagem = "";
            int valor = 0;
            int recebeOpcao = 0;
            var MyClass = new Program();

            //Adicionado contador
            Console.WriteLine("conta " + (listaResultados.Count + 1));
            Console.WriteLine("Digite dois numeros");
            //como validar se o valor chegar vazio???

            //int valor1 = (Console.ReadLine().Trim() == "" ? "Digite um valor válido." : int.Parse(Console.ReadLine());
            //string valor1 = (Console.ReadLine().Trim() == "" ? "Digite um valor válido." : valor1.int.Parse(Console.ReadLine()));

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

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
                //Valida recebeOpcao

                if (recebeOpcao == 1)
                {
                    valor = MyClass.SomarNumeros(valor1, valor2);
                    mensagem = "A soma de " + valor1 + " + " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 2)
                {
                    valor = MyClass.SubtrairNumeros(valor1, valor2);
                    mensagem = "A subtração de " + valor1 + " - " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 3)
                {
                    valor = MyClass.MultiplicarNumeros(valor1, valor2);
                    mensagem = "A multiplicação de " + valor1 + " x " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 4)
                {
                    valor = MyClass.DividirNumeros(valor1, valor2);
                    mensagem = "A divisão de " + valor1 + " / " + valor2 + " é igual a " + (valor);
                }
                else
                {
                    Console.WriteLine(recebeOpcao + " é uma opção inválida!");
                }

                //Valida mensagem
                if (mensagem != "")
                {
                    Console.WriteLine(mensagem);
                    listaResultados.Add(mensagem);
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
                    Thread.Sleep(500);
                    Console.Clear();
                    ChamarMetodos(listaResultados);
                }
                else
                {
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("Que pena , então vamos deixar para a próxima.");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("A quantidade de contas realizadas foi: " + listaResultados.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Lista de contas: ");

                    for (int i = 0; i < listaResultados.Count; i++)
                    {
                        //Console.WriteLine(i + " - " + listaResultados[i].NomeConta + " - " + listaResultados[i].TempoIdeal + " - " + listaResultados[i].TempoReal);                
                        Console.WriteLine("Conta " + (i + 1) + " - " + listaResultados[i]);
                    }
                    //Environment: Encerra o processo "decisaoDeContinuar" e retorna um código de saída para o sistema operacional.
                    Environment.Exit(decisaoDeContinuar);
                }
                ChamarMetodos(listaResultados);

            } while (recebeOpcao >= 1 || recebeOpcao <= 4);
        }   
    }
}
