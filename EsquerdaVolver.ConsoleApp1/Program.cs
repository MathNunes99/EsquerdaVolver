using System;

namespace EsquerdaVolver.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Desafio Esquerda Volver!");
            Console.WriteLine("");
            Console.WriteLine("Digite quantos comandos vão ser executador");

            int executar = int.Parse(Console.ReadLine());
            if (executar == 0)
            {
                Console.WriteLine("Sem Comandos para o soldado!");
                Console.ReadLine();
                Console.WriteLine("Dado o soldado iniciando para a posição N- Norte");
                       
            }
            else
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Escreva E, para girar 90 graus para ESQUERDA");
                Console.WriteLine("Escreva D, para girar 90 graus para DIREITA");

                Console.WriteLine();
                Console.WriteLine("ESCREVA OS COMANDOS!");
                string strComandos = Console.ReadLine();
                char[] comandos = new char[executar];

                comandos = strComandos.ToCharArray();
                char posicao = 'N';

                for (int i = 0; i < comandos.Length; i++)
                {
                    if (posicao == 'N')
                    {
                        if (comandos[i] == 'E')
                        {
                            posicao = 'O';
                        }
                        if (comandos[i] == 'D')
                        {
                            posicao = 'L';
                        }
                        continue;
                    }
                    if (posicao == 'O')
                    {
                        if (comandos[i] == 'E')
                        {
                            posicao = 'S';
                        }
                        if (comandos[i] == 'D')
                        {
                            posicao = 'N';
                        }
                        continue;
                    }
                    if (posicao == 'S')
                    {
                        if (comandos[i] == 'E')
                        {
                            posicao = 'L';
                        }
                        if (comandos[i] == 'D')
                        {
                            posicao = 'O';
                        }
                        continue;
                    }
                    if (posicao == 'L')
                    {
                        if (comandos[i] == 'E')
                        {
                            posicao = 'N';
                        }
                        if (comandos[i] == 'D')
                        {
                            posicao = 'S';
                        }
                        continue;
                    }

                }
                Console.WriteLine("A posição final do soldado é: " + posicao);
                Console.ReadLine();
            }
        }
    }
}
