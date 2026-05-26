namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa;

public class TelaCaixa
{
    public string? ObterOpcaoMenu()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Caixas");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar caixa");
        Console.WriteLine("2 - Editar caixa");
        Console.WriteLine("3 - Excluir caixa");
        Console.WriteLine("4 - Visualizar caixas");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");

        string? opcaoMenuInterno = Console.ReadLine()?.ToUpper();

        return opcaoMenuInterno;
    }
}
