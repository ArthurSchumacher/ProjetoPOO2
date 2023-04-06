using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class ProdutoTestes : BaseTestes
{
    public ProdutoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Produtos:");
        foreach (Produto item in _contexto.Produtos.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
