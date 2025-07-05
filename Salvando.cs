using System;
using System.Reflection;


class Cuzin
{
    static void Main()
    {
        string isso;
        //double dep;
        double saldo = 500000;
        double vlr = 1;
        string tan;

    inicio:
        Console.WriteLine("Oque deseja fazer, Depositar,Sacar ou Finalizar?");
        isso = Console.ReadLine();
        if (isso == "Depositar")
        {
            // Depositar

            Console.WriteLine("Digite o valor que quer adicionar a sua conta: ");
            vlr = double.Parse (Console.ReadLine());
            saldo += vlr;
            Console.WriteLine(saldo);
        Dep: Console.WriteLine("Deseja adicionar mais?(Yes) or (No)");
            tan = Console.ReadLine();

            while (tan == "Yes")
            {

                Console.WriteLine("Digite o valor que quer adicionar a sua conta: ");
                vlr = double.Parse (Console.ReadLine());
                saldo += vlr;
                Console.WriteLine(saldo);
                Console.WriteLine("Deseja adicionar mais?(Y) or (N)");
                tan =Console.ReadLine();
            }
            if (tan == "No") { goto inicio; }
            else { Console.WriteLine("Por favor, digite algo válido"); goto Dep; }

        }
        else if (isso == "Sacar")
        {
            // Retirada

            Console.WriteLine("Digite o valor que quer retirar de: {0}", saldo);
            vlr = double.Parse (Console.ReadLine());

            if (vlr <= saldo)
            {
                // double vaa = saldo - vlr;
                // double res = vaa;
                saldo -= vlr;
                Console.WriteLine("Valor pego: {0}", vlr);
                Console.WriteLine("Saldo restante: {0}", saldo);
            }
            else
            {
                Console.WriteLine("Saldo excedido");
            }
            while (saldo != 0)
            {
            Retir:
                Console.WriteLine("Deseja fazer mais retiradas?(Y) or (N)");
                tan = Console.ReadLine();

                if (tan == "Yes")
                {
                    // double vaa = saldo - vlr;
                    //double res = vaa;
                    // double sub = saldo - vlr;
                    //vaa = sub;


                    Console.WriteLine("Digite o valor que quer retirar de: {0}", saldo);
                    vlr = double.Parse (Console.ReadLine());
                    if (vlr <= saldo)
                    {
                        saldo -= vlr;
                        Console.WriteLine("Valor pego: {0}", vlr);
                        Console.WriteLine("Saldo restante: {0}", saldo);
                    }
                    else
                    {
                        Console.WriteLine("Saldo excedido");
                        return;
                    }
                }
                else if (tan == "No")
                {
                    goto inicio;
                }
                else if (tan != "Yes" || tan != "No")
                {
                    Console.WriteLine("Digite outra letra");
                }

                else
                {
                    Console.WriteLine("Por favor, digite algo válido");
                    goto Retir;

                }
                if (saldo == 0) Console.WriteLine("Seu saldo está vazio");
            }
        }
        else if (isso == "Finalizar")
        {

            Console.WriteLine("Obrigado pela estadia :)");
            return;

        }
        else { Console.WriteLine("Por favor, digite algo válido!"); goto inicio; }
    }
}
