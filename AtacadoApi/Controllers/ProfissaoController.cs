using Atacado.Poco;
using Atacado.Service;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/RecursosHumanos/")]
public class ProfissaoController : BaseController
{
    private ProfissaoServico _service;

    public ProfissaoController() : base()
    {
        _service = new ProfissaoServico(context);
    }

    [HttpGet("Profissoes")]
    public ActionResult<List<ProfissaoPoco>> GetAll()
    {
        try
        {
            return Ok(_service.Listar());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet("[controller]/{id}")]
    public ActionResult<ProfissaoPoco> GetById(int id)
    {
        try
        {
            return Ok(_service.Ler(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpPost("[controller]")]
    public ActionResult<ProfissaoPoco> Post([FromBody]ProfissaoPoco poco)
    {
        try
        {
            return Ok(_service.Adicionar(poco));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpPut("[controller]")]
    public ActionResult<ProfissaoPoco> Put([FromBody]ProfissaoPoco poco)
    {
        try
        {
            return Ok(_service.Atualizar(poco));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpDelete("[controller]/{chave}")]
    public ActionResult<ProfissaoPoco> Delete(int chave)
    {
        try
        {
            return Ok(_service.Remover(chave));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}
