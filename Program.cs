using System;

using System.Reflection;

internal class cuzin

{
    private static void Main()

    {
        string isso;

        //double dep;

        double saldo = 500000;

        double vlr;
        int senha=0, senha1=0;
        char tan;

        do
        {
            Console.WriteLine("Bem vindo ao Banco Cuzin! Você já possui conta? (y) ou (n)");
            tan = char.Parse(Console.ReadLine());
            if (tan != 'y')
            {
                Console.WriteLine("Por favor, crie uma senha primeiro com números.");
                senha1 = int.Parse(Console.ReadLine()); 

            }
            else
            {
                Console.WriteLine("Digite sua senha: ");
                senha = char.Parse (Console.ReadLine());
            }
            if (senha != senha1)
            {
                Console.WriteLine("Senha incorreta, tente novamente.");
                senha = int.Parse(Console.ReadLine());
                senha = senha1;
            }
            else
            {
                Console.WriteLine("Senha correta!");
            }
        } while (tan != 'y');

    inicio:

        Console.WriteLine("Oque deseja fazer, Depositar,Sacar ou Finalizar?");

        isso = Console.ReadLine();

        if (isso == "Depositar")

        {
            // Depositar

            Console.WriteLine("Digite o valor que quer adicionar a sua conta: ");

            vlr = double.Parse(Console.ReadLine());

            saldo += vlr;

            Console.WriteLine(saldo);

        Dep: Console.WriteLine("Deseja adicionar mais?(Y) or (N)");

            tan = char.Parse(Console.ReadLine());

            while (tan == 'Y')

            {
                Console.WriteLine("Digite o valor que quer adicionar a sua conta: ");

                vlr = double.Parse(Console.ReadLine());

                saldo += vlr;

                Console.WriteLine(saldo);

                Console.WriteLine("Deseja adicionar mais?(Y) or (N)");

                tan = char.Parse(Console.ReadLine());
            }

            if (tan == 'N') { goto inicio; }
            else { Console.WriteLine("Por favor, digite algo válido"); goto Dep; }
        }
        else if (isso == "Sacar")

        {
            // Retirada

            Console.WriteLine("Digite o valor que quer retirar de: {0}", saldo);

            vlr = double.Parse(Console.ReadLine());

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

                tan = char.Parse(Console.ReadLine());

                if (tan == 'Y')

                {
                    // double vaa = saldo - vlr;

                    //double res = vaa;

                    // double sub = saldo - vlr;

                    //vaa = sub;

                    Console.WriteLine("Digite o valor que quer retirar de: {0}", saldo);

                    vlr = double.Parse(Console.ReadLine());

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
                else if (tan == 'N')

                {
                    goto inicio;
                }
                else if (tan != 'Y' || tan != 'N')

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
        else { Console.WriteLine("Por favor, digite algo válido"); goto inicio; }
    }
}