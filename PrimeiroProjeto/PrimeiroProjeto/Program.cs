// Screen Sound
string MensagemDeBoaVindas = "\nBoas vindas ao Screen Sound";
//List<string> ListasDasBandas = new List<string> { "U2", "The Beatles", "Imagine Dragons" };

Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
BandasRegistradas.Add("The Beatles", new List<int>());


void ExibirLogo()
{
    Console.WriteLine("\r\n░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░\r\n██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗\r\n╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║\r\n░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║\r\n██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝\r\n╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    
    Console.WriteLine(MensagemDeBoaVindas);
    
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: MediaBanda();
            break;
        case -1:Console.WriteLine("Tchau tchau");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registros das Bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    BandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

    void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
   
    ///for (int i = 0; i < ListasDasBandas.Count; i++)
    ///{  
    ///    Console.WriteLine($"Banda: {ListasDasBandas[i]}");
    /// }
    
    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '0');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarUmaBanda()
{
    ///digite qual banda deseja avaliar 
    ///se a banda existir no dicionário >> atribuir uma nota
    ///se não volta ao menu principal
    
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota da banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void MediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média Banda");
    Console.WriteLine("Digite o nome da banda que deseja mostrar a média: ");
    string nomeDaBanda = Console.ReadLine()!;  
    if (BandasRegistradas.ContainsKey (nomeDaBanda))  
    {
        List<int> notasDaBanda = BandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}




ExibirOpcoesDoMenu();