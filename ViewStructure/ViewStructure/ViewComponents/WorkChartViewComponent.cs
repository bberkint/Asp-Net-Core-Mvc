using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewComponent: ViewComponent
    {


        List<WorkChart> workCharts = new List<WorkChart>() { 
        
            new WorkChart("Berkin", new List<bool>(){true, true, true, true,true }),
            new WorkChart("Sinem", new List<bool>(){true, false, false, true,true }),
            new WorkChart("Leyla", new List<bool>(){ false, true, true, true,false }),
            new WorkChart("Aslan Can", new List<bool>(){true, true, false, true,false }),

        };
        public IViewComponentResult Invoke() { 
            
            return View(workCharts);
        }

    }
}
