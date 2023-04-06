using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class BancoTestes : BaseTestes
{
    public BancoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Bancos:");
        foreach (Banco item in _contexto.Bancos.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
