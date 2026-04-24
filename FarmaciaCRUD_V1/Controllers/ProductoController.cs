using FarmaciaCRUD_V1.Data;
using FarmaciaCRUD_V1.Data.AccesData;
using FarmaciaCRUD_V1.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FarmaciaCRUD_V1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly DAProducto _daProducto;

        public ProductoController(DAProducto daProducto)
        {
            _daProducto = daProducto;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var lista = _daProducto.GetProducto();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var producto = _daProducto.GetById(id);
            if (producto == null) return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest("Producto viene null");
            }

            var nuevo = _daProducto.Add(producto);
            return Ok(nuevo);
            /*var nuevo = _daProducto.Add(producto);
            return Ok(nuevo);*/
        }

        [HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] Producto producto)
        public IActionResult Put(int id, Producto producto)

        {
            var updated = _daProducto.Update(id, producto);
            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _daProducto.Delete(id);
            if (!eliminado) return NotFound();

            return NoContent();
        }
    }
}
