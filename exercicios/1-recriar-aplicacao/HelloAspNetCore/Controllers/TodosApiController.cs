using System.Linq;
using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    public class TodosApiController : Controller
    {
        private ApplicationDbContext db;

        // o ASP.NET core "dá-nos a BD" no construtor.
        public TodosApiController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var tarefas = db.Todos.ToList();

            return Ok(tarefas);
        }
    }
}