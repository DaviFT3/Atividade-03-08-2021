using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero correspondente a opcao:\n1-Questao - MMC\n2-Questao - Ano bissexto\n3-Questao - Raiz Cubica\n4-Questao - MMC\n5-Questao - Tempo de jogo\n");
            var op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 4:
                    Questao4();
                    break;
                case 5:
                    Questao5();
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;

            }
        }
        public static bool Questao1()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite o nome:");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite a Idade:");
                var idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a altura:");
                var altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o peso:");
                var peso = Convert.ToDouble(Console.ReadLine());

                var imc = peso / (altura * altura);
                Console.WriteLine($"\nNome : {nome}\nIdade: {idade}\nAltura: {altura}\nPeso: {peso}\n\nIMC: {imc}");
                Console.WriteLine("\n \n ############################################################################# \n \n");

            }
            return true;
        }
        public static bool Questao2()
        {
            Console.WriteLine("Digite o primeiro ano");
            var data1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo ano");
            var data2 = Convert.ToInt32(Console.ReadLine());
            if (data1 > data2)
            {
                Console.WriteLine("Dados invalidos");
            }
            else
            {
                var count = 0;
                for (int x = data1; x <= data2; x++)
                {
                    if (x % 4 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Quantidade de anos bissextos entre {data1} e {data2} : {count}");
            }
            return true;
        }
        public static bool Questao3()
        {
            Console.WriteLine("Digite um numero");
            var num = Convert.ToDouble(Console.ReadLine());
            var resultado = Math.Pow(num, 1.0 / 3.0);
            Console.WriteLine($"Resultado : {resultado}");
            return true;
        }
        public static bool Questao4()
        {
            Console.WriteLine("Digite um valor:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int mmc = 0;
            int aux = 0;
            for (int i = 2; i <= num2; i++)
            {
                aux = num1 * i;
                if ((aux % num2) == 0)
                {
                    mmc = aux;
                    i = num2 + 1;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(mmc);
            return true;
        }
        public static bool Questao5()
        {
            Console.WriteLine("Digite a hora:");
            var hr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os minutos:");
            var min1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora:");
            var hr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os minutos:");
            var min2 = Convert.ToInt32(Console.ReadLine());
            int hora = 0;
            int min = 0;
            if (hr2 == hr1 && min2 == min1)
            {
                hora = 24;
                min = 0;
            }
            else if ((hr2 > hr1 && min2 >= min1) || (hr2 >= hr1 && min2 > min1))
            {
                hora = hr2 - hr1;
                min = min2 - min1;
            }
            else if (hr2 == hr1 && min2 < min1)
            {
                hora = 23;
                min = min2 + (60 - min1);
            }
            else if (hr2 > hr1 && min2 < min1)
            {
                hora = hr2 - hr1 - 1;
                min = min2 + (60 - min1);
            }
            else if (hr2 < hr1 && min2 < min1)
            {
                hora = hr2 + (24 - hr1) - 1;
                min = min2 + (60 - min1);
            }
            else if (hr2 < hr1 && min2 >= min1)
            {
                hora = hr2 + (24 - hr1);
                min = min2 - min1;
            }
            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");
            return true;
        }
    }
}
