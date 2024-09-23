using GerenciadorDeBiblioteca.Entities;
using GerenciadorDeBiblioteca.Models.ViewModel;
using GerenciadorDeBiblioteca.NovaPasta.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        public readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get-all")]
        public IActionResult Get()
        {
            var usuario = _context.Usuarios.ToList();
            var model = usuario.Select(UsuarioViewModel.FromEntity).ToList();

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _context.Usuarios.SingleOrDefault(x=> x.Id == id);
            var model = UsuarioViewModel.FromEntity(usuario);

            return Ok(model);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(UsuarioInputModel livroModel)
        {
            var model = livroModel.FromEntity();
            var usuario = _context.Usuarios.Add(model);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = 1 }, livroModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.SingleOrDefault(t=> t.Id == id);
            if(usuario == null) 
                return NotFound("Usuário não encontrado!");

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
