using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float resul;
            double result;
            int op;

            
            void Subtra()
            {
                resul = Valor1() - Valor2();
                Console.WriteLine("O RESULTADO DA SUBTRAÇÃO FOI :" + resul);
                Menu();
            }
            
            void Mult()
            {
                resul = Valor1() * Valor2();
                Console.WriteLine("O RESULTADO DA MULTIPLACAÇÃO FOI :" + resul);

                Menu();
            }

            void Div()
            {
   
                result = Convert.ToDouble(Valor1())/ Convert.ToDouble(Valor2());
                Console.WriteLine("O RESULTADO DA DIVISÃO FOI :" + result);

                Menu();  
            }
            
            void Soma()
            { 
                resul = Valor1() + Valor2();
                Console.WriteLine("O RESULTADO DA SOMA FOI :" + resul);

                Menu();
            }

            int Valor2()
            {
                int valor2;
                Console.WriteLine("Digite o segundo valor ->");
                valor2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                return valor2;
                

            }

            int Valor1()
            {
                int valor1;
                Console.WriteLine("Digite o primeiro valor ->");
                valor1 = Convert.ToInt32(Console.ReadLine());
                return valor1;

            }

            void Menu()
            {
                Console.WriteLine("-----------------MENU-----------------");
                Console.WriteLine("\n(1)Soma\t(2)Subtrair\n(3)Dividir\t(4)Multiplicar\n(-1)Sair");
                Console.WriteLine("OPÇÃO ->");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Soma();
                        break;

                    case 2:
                        Subtra();
                        break;

                    case 3:
                        Div();
                        break;
                    case 4:
                        Mult();
                        break;

                    case -1:
                        break;

                    default:
                        Console.WriteLine("*OPÇÃO INVÁLIDA");
                        Menu();
                        break;

                }
                      
                

                


            }

            Menu();



        }

    }
}
