using IocContainer.Services;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocContainer.Controllers
{
    public class HomeController : Controller
    {

        //ConsoleLogger _log;
        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }

        public string Index([FromServices] ILog log)
        {
            log.Info("action bazlı log talebi yapılmıştır");
            return "Service is running.";
        }
    }
}
