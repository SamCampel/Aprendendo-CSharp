// Screen Sound
string Mensagem = "Boas vindas ao Screen Sound";


// void - função
void Exibir()
{   //verbatim literal
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗    ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║    ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║    ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║    ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║    ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝    ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(Mensagem);
}

void OpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoE = Console.ReadLine()!;
    int opcaoEnum = int.Parse(opcaoE);

    switch (opcaoEnum)
    {

        case 1: Console.WriteLine("Você escolheu a opção " + opcaoE);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoE);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoE);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoE);
            break;
        case -1: Console.WriteLine(" Tchau! ");
            break;

        default: Console.WriteLine("Opçãp inválida");
            break;
    }

}

Exibir();
OpcoesMenu();