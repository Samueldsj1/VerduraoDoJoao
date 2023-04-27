using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JoaoDaMelancia_Melanciomedro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fruta = 0, qtdFruta = 0, melancia = 0, manga = 0, caqui = 0, morango = 0, laranja = 0, uva = 0, goiaba = 0, pera = 0, abacaxi = 0, mamao = 0;
            int dia = 0;
            string continuar;
            double PrecoFruta = 0.0, totalPreco = 0.0, desconto = 0.0;
            Console.WriteLine("Bem-Vindo ao Verdurao do Jão !");

            while (true)
            {
                Console.WriteLine($"Que dia é hoje?  \nDomingo [1] \nSegunda [2]\n  Terça [3]\n Quarta [4]\n  Quinta [5]\n Sexta [6]\n Sabado[7] ");
                dia = int.Parse(Console.ReadLine());

                if (dia <= 0 || dia >= 8)
                {
                    Console.WriteLine("OPÇÃO INVALIDA!!!");
                }
                else
                {
                    break;
                }
            }

            do
            {

                Console.WriteLine("Melancia [1], Manga [2], Caqui [3], Morango [4], Laranja [5], Uva [6], Goiaba [7], Pêra [8], Abacaxi [9], Mamão [10]");
                fruta = (int.Parse(Console.ReadLine()));

                switch (fruta)
                {

                    case 1:
                        Console.WriteLine("Melancia --> R$ 5.56 Kg");
                        Console.Write("Quantidade: ");
                        melancia = (int.Parse(Console.ReadLine()));
                        PrecoFruta = melancia * 5.56;
                        break;
                    case 2:
                        Console.WriteLine("Manga --> R$ 4.99 Kg");
                        Console.Write("Quantidade: ");
                        manga = (int.Parse(Console.ReadLine()));
                        PrecoFruta = manga * 4.99;
                        break;
                    case 3:
                        Console.WriteLine("Caqui --> R$ 7.99 Kg");
                        Console.Write("Quantidade: ");
                        caqui = (int.Parse(Console.ReadLine()));
                        PrecoFruta = caqui * 7.99;
                        break;
                    case 4:
                        Console.WriteLine("Morango --> R$ 40.0 Kg");
                        Console.Write("Quantidade: ");
                        morango = (int.Parse(Console.ReadLine()));
                        PrecoFruta = morango * 40;
                        break;
                    case 5:
                        Console.WriteLine("Laranja --> R$ 1.99 Kg");
                        Console.Write("Quantidade: ");
                        laranja = (int.Parse(Console.ReadLine()));
                        PrecoFruta = laranja * 1.99;
                        break;
                    case 6:
                        Console.WriteLine("Uva --> R$ 12.45 Kg");
                        Console.Write("Quantidade: ");
                        uva = (int.Parse(Console.ReadLine()));
                        PrecoFruta = uva * 12.45;
                        break;
                    case 7:
                        Console.WriteLine("Goiaba --> R$ 6.50 Kg");
                        Console.Write("Quantidade: ");
                        goiaba = (int.Parse(Console.ReadLine()));
                        PrecoFruta = goiaba * 6.50;
                        break;
                    case 8:
                        Console.WriteLine("Pêra --> R$ 18.99 Kg");
                        Console.Write("Quantidade: ");
                        pera = (int.Parse(Console.ReadLine()));
                        PrecoFruta = pera * 18.99;
                        break;
                    case 9:
                        Console.WriteLine("Abacaxi --> R$ 1.99 Kg");
                        Console.Write("Quantidade: ");
                        abacaxi = (int.Parse(Console.ReadLine()));
                        PrecoFruta = abacaxi * 1.99;
                        break;
                    case 10:

                        Console.WriteLine("Mamão --> R$ 2.99 Kg");
                        Console.Write("Quantidade: ");
                        mamao = (int.Parse(Console.ReadLine()));
                        PrecoFruta = mamao * 2.99;
                        break;

                }

                qtdFruta = melancia + caqui + manga + morango + laranja + goiaba + uva + pera + abacaxi + mamao;
                totalPreco += PrecoFruta;


                while (true)
                {
                    Console.WriteLine("Deseja continuar? (S/N)");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar == "S" || continuar == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVALIDA!! ");

                    }
                }
            } while (continuar == "S");

            if (dia == 2)
            {
                desconto = totalPreco * 0.01;
            }
            else if (dia == 3)
            {
                desconto = totalPreco * 0.15;
            }
            else if (dia == 4)
            {
                desconto = totalPreco * 0.17;
            }
            else if (dia == 5)
            {
                desconto = totalPreco * 0.02;
            }
            else if (dia == 6)
            {
                desconto = totalPreco * 0.03;
            }


            if (melancia >= 1)
                Console.WriteLine($"Melancia  QTD {melancia} Kg  X  5,56 R$   =  Total R$ {(melancia * 5.56)}");

            if (manga >= 1)
                Console.WriteLine($"Manga     QTD {manga}     Kg  X  3,99 R$  =  Total R$ {(manga * 3.99)}");

            if (caqui >= 1)
                Console.WriteLine($"Caqui     QTD {caqui}     Kg  X  6,25 R$  =  Total R$ {(caqui * 6.25)}");

            if (morango >= 1)
                Console.WriteLine($"Morango  QTD {morango}   Kg  X  12,99 R$  =  Total R$ {(morango * 12.99)}");

            if (laranja >= 1)
                Console.WriteLine($"Laranja  QTD {laranja}   Kg  X  2,99 R$   =  Total R$ {(laranja * 2.99)}");

            if (uva >= 1)
                Console.WriteLine($"Uva      QTD {uva}       Kg  X  8,99 R$   =  Total R$ {(uva * 8.99)}");

            if (goiaba >= 1)
                Console.WriteLine($"Goiaba   QTD {goiaba}    Kg  X  4,75 R$   =  Total R$ {(goiaba * 4.75)}");

            if (pera >= 1)
                Console.WriteLine($"Pêra     QTD {pera}      Kg  X  5,50 R$   =  Total R$ {(pera * 5.50)}");

            if (abacaxi >= 1)
                Console.WriteLine($"Abacaxi  QTD {abacaxi}   Kg   X  7,99 R$  =  Total R$ {(abacaxi * 7.99)}");

            if (mamao >= 1)
                Console.WriteLine($"Mamão    QTD {mamao}     Kg   X  3,25 R$  =  Total R$  {(mamao * 3.25)}");

            Console.WriteLine($"\nTotal Itens: R$  {totalPreco}  \nTotal Desconto: R$ {desconto}  \nPreço Total: R$ {(totalPreco - desconto)}");

            Console.ReadKey();

        }
    }
}
