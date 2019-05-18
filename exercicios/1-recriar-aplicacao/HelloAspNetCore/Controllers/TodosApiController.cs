using System.Linq;
using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCore.Controllers
{
    public class TodosApiController : Controller
    {
        private ApplicationDbContext db;

        // A base de dados é criada pelo ASP.NET
        // e disponiibilizada no construtor, por parâmetro.
        public TodosApiController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var todos = db.Todos.ToList();

            return Ok(todos);
        }
    }
}