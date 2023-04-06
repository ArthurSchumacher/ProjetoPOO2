using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class EstadoTestes : BaseTestes
{
    public EstadoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Estados:");
        foreach (Estado item in _contexto.Estados.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
