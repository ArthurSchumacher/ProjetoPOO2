using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class SubcategoriaTestes : BaseTestes
{
    public SubcategoriaTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        foreach (Subcategoria item in _contexto.Subcategorias.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
