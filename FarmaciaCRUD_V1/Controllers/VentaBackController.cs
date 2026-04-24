using FarmaciaCRUD_V1.Data.AccesData;
using Microsoft.AspNetCore.Mvc;

namespace FarmaciaCRUD_V1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaBackController : Controller
    {
        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var model = new DAVenta();
            var listado = model.GetVenta();
            return Ok(listado);
        }
    }
}
