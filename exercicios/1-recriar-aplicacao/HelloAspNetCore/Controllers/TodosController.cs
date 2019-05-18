using System.Linq;
using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    public class TodosController : Controller
    {
        private ApplicationDbContext db;

        // A base de dados é criada pelo ASP.NET
        // e disponiibilizada no construtor, por parâmetro.
        public TodosController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var todos = db.Todos.ToList();

            return View(todos);
        }
    }
}