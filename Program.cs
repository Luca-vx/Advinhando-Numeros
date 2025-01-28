internal class Program
{
    private static void Main(string[] args)
    {
        // Chamei a função Random para gerar um numero aleatorio entre 1 e 11, 11 não é sorteado, para ser o numero pensado pela maquina
        Random random = new Random();
        int numeroMaquina = random.Next(1, 11);

        // Valor default do usuario que sera alterado sempre que o usuario digitar algum valor.
        int numeroUsuario = 0;

        // Contador de repetições.
        int i = 0;
        
        Console.WriteLine($"Ola, Bem vindo ao jogo da advinhação\nNeste jogo eu irei pensar em um numero entre 1 e 10 \nO seu trabalho é advinhar em qual numero estou pensando.\n");
        while (i < 10 || numeroUsuario == numeroMaquina)
        {
            numeroUsuario = Convert.ToInt32(Console.ReadLine());
            if (numeroUsuario == numeroMaquina)
            {
                Console.WriteLine($"Voce acertou o numero é {numeroMaquina} e precisou de {i + 1} tentativas");
                break;
            }
            else if (numeroUsuario >= numeroMaquina)
            {
                Console.WriteLine($"Voce escolheu um numero muito alto, restam {10 - (i + 1)} tentativas");
                i++;
            }
            else
            {
                Console.WriteLine($"Voce escolheu um numero muito baixo, restam {10 - (i + 1)} tentativas");
                i++;
            }
        }
        Console.ReadKey();
    }
}