Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int palpite = 0; 
        int tentativas = 0; 

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número que estou pensando (entre 1 e 100):");

        while (palpite != numeroAleatorio)
        {
            Console.Write("Digite seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("Muito baixo! Tente um número maior.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("Muito alto! Tente um número menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
            }
        }