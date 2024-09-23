using GerenciadorDeBiblioteca.Entities;
using GerenciadorDeBiblioteca.Models;
using GerenciadorDeBiblioteca.Models.ViewModel;
using GerenciadorDeBiblioteca.NovaPasta.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/livros")]
    public class LivroController : ControllerBase
    {
        public readonly DataContext _context;
        public LivroController(DataContext context)
        {
            _context = context; 
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos()
        {
            var livros = _context.Livros.ToList();
            var model = livros.Select(ObterLivrosViewModel.FromEntity).ToList();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Consultar(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);
            if (livro == null)
                return NotFound();

            var model = ObterLivrosViewModel.FromEntity(livro);
            return Ok(model);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(LivroInputModel livroModel)
        {
            if (string.IsNullOrEmpty(livroModel.Titulo)|| string.IsNullOrEmpty(livroModel.Autor) || string.IsNullOrEmpty(livroModel.ISBN) || livroModel.AnoPublicacao == null)
                return NotFound("Por favor, preencha todos os parâmetros!");

            var livro = livroModel.FromEntity();

            var result = _context.Livros.Add(livro);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("devolver")]
        public IActionResult Devolver(int livroId)
        {
            var emprestimo = _context.Emprestimo.SingleOrDefault(t=> t.IdLivro == livroId);
            if (emprestimo == null)
                return NotFound();

            var diasAtraso = (DateTime.Now.Date - emprestimo.DataDeDevolucao.Date).TotalDays;

            emprestimo.Devolver();

            _context.Emprestimo.Update(emprestimo);
            _context.SaveChanges();

            return Ok((DateTime.Now > emprestimo.DataDeDevolucao ? $"Entrega com {diasAtraso} dias de atraso." : "Entrega concluída em dia!"));
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var livro = _context.Livros.SingleOrDefault(l => l.Id == id);
            if (livro == null)
                return NotFound();

            var result = _context.Livros.Remove(livro);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
