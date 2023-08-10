using System;
using BlazorAlunos.Model;

namespace BlazorAlunos.Services
{
	public interface IAlunoService
	{
		Task<IEnumerable<Aluno>> GetAlunos();
		Task<Aluno?> GetAlunoById(int id);
		Task SaveAluno(Aluno aluno);
		Task DeleteAluno(int id);
	}
}

