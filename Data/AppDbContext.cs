using System;
using BlazorAlunos.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAlunos.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}
		public DbSet<Aluno> Alunos { get; set; }
	}
}

