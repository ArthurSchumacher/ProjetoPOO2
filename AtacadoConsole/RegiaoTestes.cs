using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class RegiaoTestes : BaseTestes
{
    public RegiaoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Regioes:");
        foreach (Regiao item in _contexto.Regioes.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
