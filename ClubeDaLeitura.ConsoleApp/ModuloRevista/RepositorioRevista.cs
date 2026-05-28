namespace ClubeDaLeitura.ConsoleApp.ModuloRevista;

public class RepositorioRevista
{
    private readonly Revista[] registros = new Revista[100];

    public void Cadastrar(Revista novaRevista)
    {
        for (int i = 0; i < registros.Length; i++)
        {
            if (registros[i] == null)
            {
                registros[i] = novaRevista;
                break;
            }
        }
    }

    public Revista[] SelecionarTodos()
    {
        return registros;
    }
}
