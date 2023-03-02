string nome1, nome2;
string resposta;
string[] palavra_secreta = new string[10];
string[] palavra_visivel = new string[10];
int i, tentativas, tentativa1, tentativa2, opcao, encontrado = 0, ponto = 0, ponto2 = 0;

//ATRIBUINDO VALORES


Console.WriteLine("\n\n==================================================================================================================================================");
Console.WriteLine("\n=================================================================1- single player=================================================================");
Console.WriteLine("\n==================================================================================================================================================");
Console.WriteLine("\n==================================================================2-multiplayer===================================================================");
Console.WriteLine("\n==================================================================================================================================================");

Console.WriteLine("\n\nEscolha sua opção");
opcao = int.Parse(Console.ReadLine());


switch (opcao)
{
    case 1:

        for (i = 0; i <= 9; i++)
        {
            
            Console.Clear();

            Console.WriteLine((i + 1) + "ª Letra da palavra (total de 10 letras)");
            palavra_secreta[i] = Console.ReadLine();
        }

        for (i = 0; i <= 9; i++)
        {
            Console.Write(palavra_secreta[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        Console.Clear();

        tentativas = 0;

        while (tentativas < 10)
        {
            Console.Clear();

            for (i = 0; i <= 9; i++)
            {
                Console.Write(palavra_visivel[i] + " ");
            }
            Console.WriteLine("");

            // Usuário informa uma LETRA para tentativa de acerto...

            Console.WriteLine("informe uma letra... (Você tem 10 tentativas e ja gastou " + tentativas + " Tentativas)");
            Console.WriteLine("");
            resposta = Console.ReadLine();

            tentativas++;

            // JOGO verifica se a LETRA informada EXISTE na Palavra Secreta...

            for (i = 0; i <= 9; i++)
            {
                if (resposta == palavra_secreta[i])
                {
                    palavra_visivel[i] = resposta;
                    encontrado = 1;
                }
            }

            // Se LETRA não existe, JOGO informa Letra Incorreta!

            if (encontrado == 0)
            {
                Console.WriteLine("VOCÊ ERROU!!");
            }

            encontrado = 0;

            // Para o SIM e para o NÃO, JOGO consome 1 tentativa sempre...

            Console.WriteLine("\n\npreccione enter para continuar...");
            resposta = Console.ReadLine();

        }
    break;

    case 2:

        Console.Clear();

        Console.WriteLine("Qual o nome do jogador 1?");
        nome1 = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Qual o nome do jogador 2?");
        nome2 = Console.ReadLine();

        Console.Clear();

        for (i = 0; i <= 9; i++)
        {
            Console.WriteLine((i + 1) + "ª Letra da palavra (total de 10 letras)");
            palavra_secreta[i] = Console.ReadLine();

            Console.Clear();
        }

        for (i = 0; i <= 9; i++)
        {
            Console.Write(palavra_secreta[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();

        Console.Clear();

        tentativas = 0;
        tentativa1 = 0;
        tentativa2 = 0;

        while (tentativa1 < 5 || tentativa2 < 5)
        {
            Console.Clear();

            //MOSTRANDO PALAVRA SECRETA

            for (i = 0; i <= 9; i++)
            {
                Console.Write(palavra_visivel[i] + " ");
            }
            Console.WriteLine("");

            //VEZ JOGADOR 1

            Console.WriteLine("\n\n========================================================================================================================================");
            Console.WriteLine("\n====================================================== JOGADOR: " + nome1 + " SUA VEZ ================================================");
            Console.WriteLine("\n======================================================================================================================================");

            // Usuário informa uma LETRA para tentativa de acerto...

            Console.WriteLine("\n\ninforme uma letra... (Você tem 5 tentativas e ja gastou " + tentativa1 + " Tentativas)");
            Console.WriteLine("");
            resposta = Console.ReadLine();

            tentativa1++;


            // JOGO verifica se a LETRA informada EXISTE na Palavra Secreta...

            for (i = 0; i <= 9; i++)
            {
                if (resposta == palavra_secreta[i])
                {
                    palavra_visivel[i] = resposta;
                    encontrado = 1;
                    ponto = (ponto + 1);
                }
            }

            // Se LETRA não existe, JOGO informa Letra Incorreta!

            if (encontrado == 0)
            {
                Console.WriteLine("VOCÊ ERROU!!");
            }

            encontrado = 0;

            // Para o SIM e para o NÃO, JOGO consome 1 tentativa sempre...

            Console.WriteLine("\n\npressione enter para continuar...");
            resposta = Console.ReadLine();

            Console.Clear();

            //MOSTRANDO A PALAVRA SECRETA

            for (i = 0; i <= 9; i++)
            {
                Console.Write(palavra_visivel[i] + " ");
            }
            Console.WriteLine("");

            //VEZ JOGADOR 2

            Console.WriteLine("\n\n========================================================================================================================================");
            Console.WriteLine("\n====================================================== JOGADOR: " + nome2 + " SUA VEZ ================================================");
            Console.WriteLine("\n======================================================================================================================================");

            // Usuário informa uma LETRA para tentativa de acerto...

            Console.WriteLine("\n\ninforme uma letra... (Você tem 5 tentativas e ja gastou " + tentativa2 + " Tentativas)");
            Console.WriteLine("");
            resposta = Console.ReadLine();

            tentativa2++;

            // JOGO verifica se a LETRA informada EXISTE na Palavra Secreta...

            for (i = 0; i <= 9; i++)
            {
                if (resposta == palavra_secreta[i])
                {
                    palavra_visivel[i] = resposta;
                    encontrado = 1;
                    ponto2 = (ponto2 + 1);
                }
            }

            // Se LETRA não existe, JOGO informa Letra Incorreta!

            if (encontrado == 0)
            {
                Console.WriteLine("VOCÊ ERROU!!");
            }

            encontrado = 0;

            // Para o SIM e para o NÃO, JOGO consome 1 tentativa sempre...

            Console.WriteLine("\n\npressione enter para continuar...");
            resposta = Console.ReadLine();

        }

        //GANHADOR

        Console.Clear();

        if (ponto > ponto2)
        {
            Console.WriteLine(nome1 + " VOCÊ GANHOU COM " + ponto + " PONTO(S)");
        }
        if (ponto < ponto2)
        {
            Console.WriteLine(nome2 + " VOCÊ GANHOU COM " + ponto2 + " PONTO(S)");
        }
        if (ponto == ponto2)
        {
            Console.WriteLine("OCORREU UM EMPATE, AMBOS FIZERAM A MESMA PONTUACÃO");
        }
        break;
}