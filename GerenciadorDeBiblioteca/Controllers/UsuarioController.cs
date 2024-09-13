using GerenciadorDeBiblioteca.Models.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return Ok();
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(LivroInputModel livroModel)
        {
            return CreatedAtAction(nameof(GetById), new {}, livroModel);
        }

        [HttpDelete("deletar")]
        public IActionResult Delete()
        {
            return NoContent();
        }

    }
}
