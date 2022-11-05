using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Seja Bem-Vindo!\nO que deseja fazer?");
        Console.WriteLine("1 -  Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            default: Menu(); break;
        }
    }

    static void Abrir()
    {

    }

    static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine; //para quebrar linha e ter espaço
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape); //enquanto não apertar a tecla esc, pode digitar tranquilo

        Salvar(text);


    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path)) //todo objeto que passar dentro do using ele ja vai abrir e fechar automaticamente, bom para não cometer erros de esquecer de fechar as coisas!
        {
            file.Write(text);
        }
        
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
        Menu();
    }
}