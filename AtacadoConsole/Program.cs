namespace AtacadoConsole;

using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        var contexto = new AtacadoContext();
        BaseTestes categoriaTestes = new SubcategoriaTestes(contexto);

        Console.WriteLine("Executando pesquisa...");
        categoriaTestes.Imprimir();
        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}