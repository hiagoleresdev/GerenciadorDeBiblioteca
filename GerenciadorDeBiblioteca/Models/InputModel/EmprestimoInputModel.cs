﻿using GerenciadorDeBiblioteca.Models;

namespace GerenciadorDeBiblioteca.NovaPasta.InputModel
{
    public class EmprestimoInputModel
    {
        public EmprestimoInputModel(int idUsuario, int idLivro, DateTime dataEmprestimo, DateTime dataDeDevolucao)
        {
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
            DataDeDevolucao = dataDeDevolucao;
        }

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }

        public static Emprestimo FromEntity(EmprestimoInputModel e) => new (e.IdUsuario, e.IdLivro, e.DataEmprestimo, e.DataDeDevolucao);
    }
}
