using System.Linq;

namespace HelloAspNetCore.Data
{
    public class DbSeeder
    {
        public DbSeeder(ApplicationDbContext db)
        {
            Db = db;
        }

        public ApplicationDbContext Db { get; }

        public void Seed()
        {
            // Impedir o seed se já houver dados.
            if (Db.Todos.Any())
            {
                return;
            }

            var todos = new[]
            {
                new Todo { Id = 1, Description = "Tarefa 1" },
                new Todo { Id = 2, Description = "Tarefa 2" }
            };

            foreach (var todo in todos)
            {
                Db.Todos.Add(todo);
            }

            Db.SaveChanges();
        }
    }
}