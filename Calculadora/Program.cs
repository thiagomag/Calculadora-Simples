using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        bool sair = true;
        while (sair)
        {
            Console.WriteLine("Escolha o primeiro valor:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha o segundo valor:");
            double y = Convert.ToDouble(Console.ReadLine());

            int opc;
            do
            {
                Console.WriteLine("Escolha a opção desejada\n" +
                                  "1 - Soma\n" +
                                  "2 - Subtração\n" +
                                  "3 - Multiplicação\n" +
                                  "4 - Divisão\n" +
                                  "5 - Resto da divisão");
                opc = Convert.ToInt32(Console.ReadLine());
            } while (opc < 1 || opc > 5);

            switch (opc)
            {
                case 1:
                    double soma = x + y;
                    Console.WriteLine("SOMA (X+Y) = " + soma);
                    break;
                case 2:
                    double subtracao = x - y;
                    Console.WriteLine("SUBTRAÇÃO (X-Y) = " + subtracao);
                    break;
                case 3:
                    double multiplicacao = x * y;
                    Console.WriteLine("MULTIPLICAÇÃO (X*Y) = " + multiplicacao);
                    break;
                case 4:
                    double divisao = x / y;
                    Console.WriteLine("DIVISÃO (X/Y) = " + divisao);
                    break;
                case 5:
                    int modulo = Convert.ToInt32(x % y);
                    Console.WriteLine("RESTO DA DIVISÃO = " + modulo);
                    break;
            }
            Console.WriteLine("Deseja continuar? (sim/não)");
            string resp = Console.ReadLine().ToLower();
            if (resp == "não")
            {
                sair = false;
            }
        }
        }
    }
}
