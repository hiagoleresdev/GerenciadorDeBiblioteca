using GerenciadorDeBiblioteca.Models.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/biblioteca")]
    public class LivroController : ControllerBase
    {
        [HttpPost("adicionar")]
        public IActionResult AdicionarLivro(LivroInputModel livroModel)
        {
            return Ok();
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Consultar(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            return NoContent();
        }

        [HttpPost("devolver")]
        public IActionResult Devolver()
        {
            return Ok();
        }
    }
}
