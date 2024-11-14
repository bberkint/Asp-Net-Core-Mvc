using Interfaces.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interfaces.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MsSqlOperation mssql = new MsSqlOperation();
            mssql.Connetction();

            ISqlOperation sql = new MsSqlOperation();
            sql.Connetction();

            ISqlOperation mysql = new MySqlOperation();
            mysql.Connetction();    

           
            return View();
        }
    }
}
