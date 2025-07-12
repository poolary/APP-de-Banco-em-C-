using System;
using System.Collections.Generic;

class TopUm
{

    static void Main(string[] args)
    {
        bool Ativa = Console.CapsLock; ConsoleColor cor = ConsoleColor.Red; Console.ForegroundColor = cor; Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("O caps tá: " + (Ativa ? "Ligado" : "Desligado")); int chances = 3;

        // Console.Beep(2000, 400); // Beep com frequência de 2000Hz e duração de 400ms

        Console.CursorVisible = false; // Esconde o cursor */

        /*  ConsoleSpecialKey teclaEspecial = ConsoleSpecialKey.ControlC; // Define uma tecla especial (Control+C)
          ConsoleKeyInfo teclaEsppecial = Console.ReadKey(); // Lê a tecla especial pressionada */
        Contas nomes = new Contas();
        Console.WriteLine("Digite seu nome: ");
        nomes.Nome = Console.ReadLine()!;
        Console.Clear();

        Contas email = new Contas();
        Contas senha = new Contas();
        Console.WriteLine("Digite seu email: ");
        email.Email = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Digite sua senha: ");
        senha.Senha = Console.ReadLine()!;
        Console.WriteLine("Confirme sua senha: ");
        string senhaConfirmada = Console.ReadLine()!;

        if (senhaConfirmada == senha.Senha)
        {
            Console.Clear();

            Console.WriteLine("Dados Cadastrados! Deseja exibir suas informações? Caso sim, clique na tecla (C) ");

            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.C)
            {
                Console.ResetColor();
                Console.Clear(); Console.WriteLine("Nome: " + nomes.Nome); Console.WriteLine("Email: " + email.Email); Console.WriteLine("Senha: " + senha.Senha);
            }
            else { Console.Clear(); Console.WriteLine("Bem vindo(a), {0}", nomes.Nome); }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Senha incorreta! Tente novamente.");
            Console.WriteLine("Você tem {0} chances", chances);
        }
        while (senhaConfirmada != senha.Senha)
        {
            Console.WriteLine("Digite sua senha novamente: ");
            senhaConfirmada = Console.ReadLine()!;
            if (senhaConfirmada == senha.Senha)
            {
                Console.Clear();
                Console.WriteLine("Senha confirmada com sucesso!");
                Console.Clear();

                Console.WriteLine("Dados Cadastrados! Deseja exibir suas informações? Caso sim, clique na tecla (C) ");

                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.C)
                {
                    Console.ResetColor();
                    Console.Clear(); Console.WriteLine("Nome: " + nomes.Nome); Console.WriteLine("Email: " + email.Email); Console.WriteLine("Senha: " + senha.Senha);
                }
                else { Console.Clear(); Console.WriteLine("Bem vindo(a), {0}", nomes.Nome); }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Senha incorreta! Tente novamente.");
                
                {
                    if (senhaConfirmada == senha.Senha)
                    {
                        Console.Clear();

                        Console.WriteLine("Dados Cadastrados! Deseja exibir suas informações? Caso sim, clique na tecla (C) ");

                        ConsoleKeyInfo tecla = Console.ReadKey();
                        if (tecla.Key == ConsoleKey.C)
                        {
                            Console.ResetColor();
                            Console.Clear(); Console.WriteLine("Nome: " + nomes.Nome); Console.WriteLine("Email: " + email.Email); Console.WriteLine("Senha: " + senha.Senha);
                        }
                        else { Console.Clear(); Console.WriteLine("Bem vindo(a), {0}", nomes.Nome); }
                        break;
                    }


                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Senha incorreta! Tente novamente.");
                        --chances;
                        if (chances > 0) { Console.WriteLine("Lhe resta: {0} chances", chances); }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Você excedeu o número de tentativas, volte novamente mais tarde.");
                            break;
                            //Environment.Exit(); 0; // Encerra o programa se as chances acabarem
                        }

                    }
                }

            }
        }
    } 
            
        
    

    public class Contas
    {

        public string Nome
        {
            get;
            set;
        }


        public string Email
        {
            get; set;
        }
        public string Senha
        {
            get; set;
        }
    }
}

    
