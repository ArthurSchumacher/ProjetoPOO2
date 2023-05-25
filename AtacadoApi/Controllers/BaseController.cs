using Atacado.DB.EF.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

public abstract class BaseController : ControllerBase
{
    protected AtacadoContext context;

    public BaseController() : base()
    {
        context = new AtacadoContext();        
    }
}