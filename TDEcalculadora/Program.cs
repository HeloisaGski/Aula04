        Console.WriteLine("Digite o primeiro número para calcular: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número para calcular: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação que deseja realizar:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int escolha = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (escolha)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"O valor da soma dos seus números é: {resultado}");
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"O valor da subtração dos seus números é: {resultado}");
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"O valor da multiplicação dos seus números é: {resultado}");
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"O valor da divisão dos seus números é: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Escolha inválida. Por favor, escolha uma operação entre 1 e 4.");
                break;
        }