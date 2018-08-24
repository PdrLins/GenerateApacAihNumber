using System;

namespace GenerateApacAihNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************          BEM VINDO AO GERADOR DE NÚMEROS APAC E AIH               **************");
            Console.WriteLine("**************  Objetivo de testes com números de guias válidas para AIH e APAC  **************");
            Console.WriteLine("**************                  Desenvolvido por Pedro Lins                      **************");
            Console.ForegroundColor = ConsoleColor.Gray;
            var answer = "1";
            Console.ForegroundColor = ConsoleColor.Gray;
            while (answer == "1")
            {
                Console.WriteLine("Por favor digitar o código UF do número da guia. Ex: 35(SP), 81(PE): ");
                var uf = Console.ReadLine();

                Console.WriteLine("Por favor digitar o ANO do número da guia. Ex: 2018, 2019: ");
                var year = Console.ReadLine();

                Console.WriteLine("Por favor digitar o TIPO da guia. Aih = 1, APAC = 2");
                var guidetype = Console.ReadLine();

                var seq1 = new Random().Next(1, 9999999).ToString().PadLeft(7, '0');
                var seq = Convert.ToInt32(seq1);
                long cod = Convert.ToInt64($"{uf}{year}{guidetype}{seq}");
                long calc = (cod - (cod / 11));
                var digito = calc.ToString().Substring(calc.ToString().Length - 1, 1);
                var result = $"{cod}{digito}";
                Console.WriteLine($"Código gerado: {result}");
                Console.WriteLine($@"Pressinoe ENTER para sair do programa.");
                Console.ReadKey();
                answer = "0";
            }
        }
    }
}
