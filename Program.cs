using System;

namespace Udemy_Console
{
    public class Program
    {
        private readonly CalculoService _CalculoService;

        public Program(CalculoService calculoService)
        {
            _CalculoService = calculoService;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
