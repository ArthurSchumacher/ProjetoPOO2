using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class CategoriaTestes : BaseTestes
{
    public CategoriaTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Categorias:");
        foreach (Categoria item in _contexto.Categorias.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
