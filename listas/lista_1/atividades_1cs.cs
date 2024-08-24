using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace atividades_bcc_ufabc.listas.lista_1
{
    internal class atividades_1cs
    {
        public class Lista1()
        {
            public static void ExA()
            //a. Ler dois números e verificar qual é o menor e qual é o maior.
            {
                Console.WriteLine("Digite o primeiro número: \n");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: \n");
                int n2 = int.Parse(Console.ReadLine());

                if (n1 > n2 && n1 != n2)
                {
                    Console.WriteLine("O número " + n1 + " é maior do que " + n2);
                }
                else if (n2 > n1 && n2 != n1)
                {
                    Console.WriteLine("O número " + n2 + " é maior do que " + n1);
                }
                else
                {
                    Console.WriteLine("Os números são iguais");
                }
            }

            public static void ExB()
            {
                //b. Ler os nomes e os pesos de duas pessoas e imprimir qual é o mais pesado.

                string[] nome = new string[2];
                double[] peso = new double[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Digite o nome da {i + 1}° pessoa: \n");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Agora o seu peso:");
                    peso[i] = double.Parse(Console.ReadLine());
                }
                if (peso[0] > peso[1])
                {
                    Console.WriteLine($"{nome[0]} é mais pesado(a) que {nome[1]}");
                }
                else
                {
                    Console.WriteLine($"{nome[1]} é mais pesado(a) que {nome[0]}");
                }
            }

            public static void ExC()
            {
                //c. Ler o ano atual e os nomes e os anos de nascimento de duas pessoas e calcular suas
                //idades e imprimir o nome e a idade de cada uma delas e dizer qual a mais nova.

                int anoAtual = 2024;
                string[] nome = new string[2];
                int[] anoNasc = new int[2];

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Digite o nome da {i + 1}° pessoa: \n");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Agora, digite o ano em que você nasceu: \n");
                    anoNasc[i] = int.Parse(Console.ReadLine());
                }
                int idade1 = anoAtual - anoNasc[0];
                int idade2 = anoAtual - anoNasc[1];

                if (idade1 < idade2)
                {
                    Console.WriteLine($"{nome[0]} tem {idade1} anos e é mais novo(a) que {nome[1]}, pois sua idade é de {idade2} anos");
                }
                else
                {
                    Console.WriteLine($"{nome[1]} tem {idade2} anos e é mais novo(a) que {nome[0]}, pois sua idade é de {idade1} anos");
                }

            }
            public static void ExD()
            {
                //d. Ler um número e verificar e imprimir na tela se ele é um número par ou ímpar.
                Console.WriteLine("Digite um número: ");
                double n = double.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("par");
                }
                else
                {
                    Console.WriteLine("ímpar");
                }

            }

            public static void ExE()
            {
                //e. Ler dois valores e mostrar a diferença entre eles.

                Console.WriteLine("Digite o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                int diferenca = n1 - n2;

                Console.WriteLine($"A diferença entre eles é de: {diferenca}");

            }

            public static void ExF()
            {
                //f. Ler um número e dizer se ele é positivo ou negativo ou zero.

                Console.WriteLine("Digite um número: ");
                int n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine($"O número {n} é positivo");
                }
                else if (n < 0)
                {
                    Console.WriteLine($"O número {n} é negativo");
                }
                else
                {
                    Console.WriteLine("O número é 0");
                }
            }

            public static void ExG()
            {
                /*g. Uma empresa dá um prêmio aos funcionários que cumprem determinado valor de
                 venda. A cada funcionário foi estabelecido um valor a ser alcançado. Faça um algoritmo
                 para ler o valor fixado e o valor de vendas de cada funcionário, e imprimir a mensagem
                 “Premiado”, se o funcionário conseguiu o prêmio, ou “nao premiado”, caso contrário.
                */

                int valorFixado = 30000;

                Console.WriteLine("Digite o nome do(a) funcionário(a): ");
                string funcionario = Console.ReadLine();

                Console.WriteLine("Agora, digite o valor de suas vendas deste mês: ");
                int valorVenda = int.Parse(Console.ReadLine());

                if (valorVenda >= valorFixado)
                {
                    Console.WriteLine("Premiado");
                }
                else
                {
                    Console.WriteLine("Não premiado");
                }

            }
            public static void ExH()
            {
                //h. Escreva um algoritmo que receba uma letra e exiba a mensagem "É UMA VOGAL”, caso a letra
                //informada seja uma vogal.

                Console.WriteLine("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine());

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    Console.WriteLine("É uma vogal");
                }
                else
                {
                    Console.WriteLine("É uma consoante");
                }

            }

            public static void ExI()
            {
                /*A montagem de uma determinada placa de circuito eletrônico exige a utilização de três tipos de
                 componentes: dois componentes do tipo A, três componentes do tipo B e sete
                 componentes do tipo C. Faça um algoritmo que receba as quantidades disponíveis de cada
                 tipo de componente e determine a quantidade máxima de placas que pode ser montada.
                */

                int tipoA, tipoB, tipoC, qtdPlaca;
                Console.WriteLine("Informe a quantidade disponível dos componentes do tipo A");
                tipoA = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade disponível dos componentes do tipo B");
                tipoB = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade disponível dos componentes do tipo C");
                tipoC = int.Parse(Console.ReadLine());

                qtdPlaca = Math.Min(tipoA / 2, Math.Min(tipoB / 3, tipoC / 7));


                Console.WriteLine($"Podem ser montadas {qtdPlaca} placas");

            }
        }
    }
}
