using System.Linq;
using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    public class TodosController : Controller
    {
        public ApplicationDbContext Db { get; set; }

        // A base de dados é inicializada pelo
        // ASP.NET Core e passada no construtor.
        public TodosController(ApplicationDbContext db)
        {
            Db = db;
        }

        public ActionResult Index()
        {
            var todos = Db.Todos.ToList();

            return View(todos);
        }
    }
}