using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelloAspNetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }

    public class DbSeeder
    {
        private ApplicationDbContext db;

        public DbSeeder(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Seed()
        {
            // Any() devolve true se a tabela tem dados.
            if (!db.Todos.Any())
            {
                // Seed dos "Todos", quando não existem dados.
                Todo[] dados = new Todo[]
                {
                    new Todo { Id = 1, Description = "Tarefa 1" },
                    new Todo { Id = 2, Description = "Tarefa 2" }
                };

                foreach (Todo todo in dados)
                {
                    db.Todos.Add(todo);
                }

                db.SaveChanges();
            }
        }
    }
}
