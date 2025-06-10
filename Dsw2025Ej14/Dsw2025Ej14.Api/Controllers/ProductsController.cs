using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers;
[ApiController]
[Route("api/[controller]")]

public class ProductsController
{
   
    private readonly PersistenciaEnMemoria _json;
    private readonly IPersistencia _persistencia;
    public ProductsController(IPersistencia persistecia)
    {
        _persistencia = persistecia;
    }
    [HttpGet()]

    public IActionResult GetProducts()
    {
        return Ok(_persistencia.GetProductsActive());
    }



}
