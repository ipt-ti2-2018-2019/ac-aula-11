using System.Linq;
using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    public class TodosController : Controller
    {
        private ApplicationDbContext db;

        public TodosController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var tarefas = db.Todos.ToList();

            return View(tarefas);
        }
    }
}