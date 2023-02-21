using Microsoft.AspNetCore.Mvc;
using WebApplication2.data;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class chartController : Controller
    {
        private readonly dbcontext _db;
        public chartController(dbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowChart()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetChart()
        {
            List<object> data = new List<object>();

            List<string> labels = _db.charttdb.Select(x => x.TheColorr).ToList();
            data.Add(labels);

            List<int> datachart = _db.charttdb.Select(x => x.data).ToList();
            data.Add(datachart);

            return data;

        }
    }
}
