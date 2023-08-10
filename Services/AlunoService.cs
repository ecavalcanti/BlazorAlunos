using System;
using BlazorAlunos.Data;
using BlazorAlunos.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAlunos.Services
{
	public class AlunoService: IAlunoService
	{
        private readonly AppDbContext _context;
        public AlunoService(AppDbContext context)
		{
            _context = context;
		}

        public async Task DeleteAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Aluno?> GetAlunoById(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            return aluno;
        }

        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task SaveAluno(Aluno aluno)
        {
            if (aluno.Id == 0)
            {
                await _context.Alunos.AddAsync(aluno);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Alunos.Update(aluno);
                await _context.SaveChangesAsync();
            }
        }
    }
}

