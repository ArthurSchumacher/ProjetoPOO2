using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public class AreaConhecimentoTestes : BaseTestes
{
    public AreaConhecimentoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Areas conhecimentos:");
        foreach (AreaConhecimento item in _contexto.AreaConhecimentos.ToList())
        {
            Console.WriteLine(item);
        }
    }
}
