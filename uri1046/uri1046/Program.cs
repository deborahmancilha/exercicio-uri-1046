using System;

namespace ex1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horainicio, horafim, tempototal1, tempototal2;


            String[] vet;

            vet = Console.ReadLine().Split(' ');
            horainicio = int.Parse(vet[0]);
            horafim = int.Parse(vet[1]);


            if (horainicio == horafim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                if (horainicio > 10 && horainicio < 24)
                {
                    tempototal1 = (24 - horainicio) + horafim;
                    Console.WriteLine("O JOGO DUROU " + tempototal1 + " HORA(S)");

                }
                else
                {
                    tempototal2 = horafim - horainicio;
                    Console.WriteLine("O JOGO DUROU " + tempototal2 + " HORA(S)");

                }
            }
        }



    }
}

