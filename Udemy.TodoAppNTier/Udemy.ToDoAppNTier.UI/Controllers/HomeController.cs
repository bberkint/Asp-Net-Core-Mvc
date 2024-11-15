using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Business.Interfaces;

namespace Udemy.ToDoAppNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;

        public HomeController(IWorkService workService)
        {
            _workService = workService;
        }

        public async Task<IActionResult> Index()
        {
            var workList = await _workService.GetAll();

            return View(workList);
        }
    }
}
