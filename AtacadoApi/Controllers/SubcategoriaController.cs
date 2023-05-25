using Atacado.DB.EF.Database;
using Atacado.Poco;
using Atacado.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/Estoque/")]
public class SubcategoriaController : BaseController
{
    private SubcategoriaServico _service;
    
    public SubcategoriaController() : base()
    {
        _service = new (context);
    }

    [HttpGet("Subcategorias")]
    public List<SubcategoriaPoco> GetAll()
    {
        return _service.Listar();
    }

    [HttpGet("Subcategorias/PorCategoria/{categoriaId}")]
    public List<SubcategoriaPoco> GetByCategoriaId(int categoriaId)
    {
        return _service.Listar(sub => sub.CodigoCategoria == categoriaId);
    }

    [HttpGet("[controller]/{id}")]
    public SubcategoriaPoco GetById(int id)
    {
        return _service.Ler(id);
    }

    [HttpPost("[controller]")]
    public SubcategoriaPoco Post([FromBody]SubcategoriaPoco poco)
    {
        return _service.Adicionar(poco);
    }

    [HttpPut("[controller]")]
    public SubcategoriaPoco Put([FromBody]SubcategoriaPoco poco)
    {
        return _service.Atualizar(poco);
    }

    [HttpDelete("[controller]/{chave}")]
    public SubcategoriaPoco Delete(int chave)
    {
        return _service.Remover(chave);
    }
}