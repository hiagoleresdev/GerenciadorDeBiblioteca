using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/emprestimos")]
    public class EmprestimoController : ControllerBase
    {
        [HttpPost("cadastrar")]
        public IActionResult Cadastrar()
        {
            return Ok();
        }

        [HttpPost("criarDataDevolucao")]
        public IActionResult CriarDataDeDevolucao(DateTime data)
        {
            return Created();
        }

        [HttpDelete("deletar")]
        public IActionResult Delete(Guid id)
        {
            return NoContent();
        }
    }
}
