namespace AtacadoConsole;

using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        var contexto = new AtacadoContext();

        Console.WriteLine("Executando pesquisa...");
        foreach (Cidade item in contexto.Cidades.AsNoTracking().ToList())
        {
            Console.WriteLine(item);
        }
        foreach (Estado item in contexto.Estados.AsNoTracking().ToList())
        {
            Console.WriteLine(item);
        }
        foreach (Regiao item in contexto.Regioes.AsNoTracking().ToList())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}