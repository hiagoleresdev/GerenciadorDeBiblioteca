﻿using GerenciadorDeBiblioteca.Entities;
using GerenciadorDeBiblioteca.Models.ViewModel;
using GerenciadorDeBiblioteca.NovaPasta.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.Controllers
{
    [ApiController]
    [Route("api/emprestimos")]
    public class EmprestimoController : ControllerBase
    {
        public readonly DataContext _context;
        public EmprestimoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get-all")]
        public IActionResult Get()
        {
            var emprestimos = _context.Emprestimo.ToList();
            var model = emprestimos.Select(EmprestimoViewModel.FromEntity).ToList();

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _context.Emprestimo.SingleOrDefault(x => x.Id == id);
            var model = EmprestimoViewModel.FromEntity(usuario);

            return Ok(model);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(EmprestimoInputModel emprestimoModel)
        {
            var livro = _context.Livros.SingleOrDefault(t => t.Id == emprestimoModel.IdLivro);
            if(livro == null)
                return NotFound("O livro não foi encontrado");

            if(livro.EstaEmprestado)
                return BadRequest("O livro não pode ser emprestadopois pois já está em um emprestimo ativo.");

            var model = EmprestimoInputModel.FromEntity(emprestimoModel);
            var emprestimo = _context.Emprestimo.Add(model);

            livro.EstaEmprestado = true;
            _context.Livros.Update(livro);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("deletar")]
        public IActionResult Delete(int id)
        {
            var emprestimo = _context.Emprestimo.SingleOrDefault(t=> t.Id == id);
            if (emprestimo == null)
                return NotFound("Emprestimo não encontrado!");

            _context.Emprestimo.Remove(emprestimo);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
