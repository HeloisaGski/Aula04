        double saldo = 1000;
        bool ativo = true;

        while (ativo)
        {
            Console.WriteLine("Bem-vindo ao Caixa Eletrônico! Como posso te ajudar hoje?");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Seu saldo atual é de: R${saldo:F2}");
                    break;

                case "2":
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    try
                    {
                        double saque = Convert.ToDouble(Console.ReadLine());
                        saldo -= saque;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Valor inválido. Por favor, digite um número.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Digite o valor que deseja depositar: ");
                    try
                    {
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        saldo += deposito;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Valor inválido. Por favor, digite um número.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Finalizando o sistema de caixa. Obrigado!");
                    ativo = false;
                    break;

                default:
                    Console.WriteLine("Opção Inválida, vamos tentar novamente?");
                    break;
            }
        }





