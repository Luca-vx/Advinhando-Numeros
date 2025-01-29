internal class Program
{
    private static void Main(string[] args)
    {
        // Chamei a função Random para gerar um numero aleatorio entre 1 e 101, 101 não é sorteado, para ser o numero pensado pela maquina
        Random random = new Random();
        bool continuar = true;

        while (continuar)
        {
            int numeroMaquina = random.Next(1, 101);

            // Valor default do usuario que sera alterado sempre que o usuario digitar algum valor.
            int numeroUsuario = 0;

            // Contador de repetições.
            int i = 0;
            int limitador = 0;

            Console.WriteLine($"Ola, Bem vindo ao jogo da advinhação\nNeste jogo eu irei pensar em um numero entre 1 e 100 \nO seu trabalho é advinhar em qual numero estou pensando\n\no jogo possui 3 dificuldades \nFacil (10 tentativas)\nMedio (5 tentativas) \nDificil (3 tentativas) \n\nEscreva abaixo qual dificuldade deseja");

            // escolhe a dificuldade do jogo
            string dificuldade = Console.ReadLine();
            switch (dificuldade.ToUpper())
            {
                case "FACIL":
                    limitador = 10;
                    break;
                case "MEDIO":
                    limitador = 5;
                    break;
                case "DIFICIL":
                    limitador = 3;
                    break;
                default:
                    Console.WriteLine("voce colocou uma dificuldade que não existe, por conta disto o jogo sera ajustado para o modo facil");
                    limitador = 10;
                    break;
            }
            // Pergunta ao usuario um numero e o compara com o escolhido pela maquina
            Console.WriteLine("digite seu numero abaixo:");
            while (i < limitador || numeroUsuario == numeroMaquina)
            {   
                numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if (numeroUsuario == numeroMaquina)
                {
                    Console.WriteLine($"Voce acertou o numero é {numeroMaquina} e precisou de {i + 1} tentativas");
                    break;
                }
                else if (numeroUsuario > numeroMaquina)
                {   
                    Console.WriteLine($"Voce escolheu um numero muito alto, restam {limitador - (i + 1)} tentativas");
                    i++;
                }
                else 
                {
                    Console.WriteLine($"Voce escolheu um numero muito baixo, restam {limitador - (i + 1)} tentativas");
                    i++;
                }            
            }
            if (numeroMaquina != numeroUsuario)
            {
                Console.WriteLine("\nVocê esgotou suas tentativas e não conseguiu acertar o numero correto");
            }
            // Pergunta se o jogador quer continuar e se sim matem o loop como while
            Console.Write("Gostaria de continuar (Y/N): ");
            string temporaria = Console.ReadLine();
            if (temporaria.ToUpper() == "Y")
            {
                continuar = true;
                Console.Clear();
            }
            else 
            {
                continuar = false;
                Console.WriteLine("Obrigado por jogar");
            }
        }
        Console.ReadKey();
    }
}