using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float menuzin;

            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("4 - Exercicio 4");
            Console.WriteLine("5 - Exercicio 5");
            Console.WriteLine("6 - Exercicio 6");
            Console.WriteLine("7 - Exercicio 7");
            menuzin = float.Parse(Console.ReadLine());

            switch (menuzin)
            {

                case 1:

                    Console.WriteLine("Digite um numero qualquer:");
                    int num = int.Parse(Console.ReadLine());
                    for (int cont = 1; cont <= num; cont++)
                    {
                        Console.WriteLine(cont);
                    }

                    break;

                case 2:
                    float res;
                    Console.WriteLine("Digite um numero qualquer maior que 1:");
                    int num1 = int.Parse(Console.ReadLine());
                    for (int cont = 1; cont <= num1; cont++)
                    {
                        res = cont % 2;
                        if (res == 0)

                            Console.WriteLine(cont);

                    }

                    break;

                case 3:
                    float res1;
                    Console.WriteLine("Digite um numero qualquer menor que 1000:");
                    int num2 = int.Parse(Console.ReadLine());
                    for (int cont = num2 ; cont <= 1000; cont++)
                    {
                        res1 = cont % 2;
                        if (res1 == 0)

                            Console.WriteLine(cont);

                    }
                    break;

                case 4:
                   int soma = 0;
                    for (; soma < 200; ) {
                        Console.WriteLine("entre com um numero:");
                        num = int.Parse(Console.ReadLine());
                        if (num > 0)
                            soma = soma + num;
                        
                            }

                    break;

                case 5:
                    Console.Write("Digite um número inteiro: ");
                    int num4 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + num4 + ":");

                    for (int i = 1; i <= num4; i++)
                    {
                        if (num4 % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                        break;

                case 6:
                    int menor, maior, num6;
                    Console.WriteLine("Digite um numero qualquer:");
                    num6 = int.Parse(Console.ReadLine());

                    menor = num6;
                    maior = num6;

                    for (int i = 0; i < 9; i++) {
                        Console.WriteLine("Digite um numero qualquer:");
                        num6 = int.Parse(Console.ReadLine());
                        if (num6 < menor) {
                            menor = num6;
                                Console.WriteLine("o menor numero é:" + menor);
                        }
                        else if (num6 < maior);
                        maior = num6;
                        Console.WriteLine("o maior numero é:" + maior);
                    }

                    break;

                case 7:
                    int somapar = 0, somaimpar = 0, num5 = 1;
                    for (; num5!=0;)

                    {
                        Console.WriteLine("Digite um numero: ");
                        num5 = int.Parse(Console.ReadLine());

                        if (num5 % 2 == 0)
                        {
                            somapar = somapar + num5;
                            Console.WriteLine("total par:" + somapar);
                        }

                        else
                            somaimpar = somaimpar + num5;
                        Console.WriteLine("total impar" + somaimpar);
                    }
                    break;

                default:
                    Console.WriteLine("opção invalida");
                    break;

            }

            Console.ReadKey();

        }
    }
}
