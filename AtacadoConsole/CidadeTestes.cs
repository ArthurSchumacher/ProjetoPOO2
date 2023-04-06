using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class CidadeTestes : BaseTestes
{
    public CidadeTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Cidades:");
        foreach (Cidade item in _contexto.Cidades.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
