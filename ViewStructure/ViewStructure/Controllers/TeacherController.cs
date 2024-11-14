using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {


        List<Teacher> teachers = new List<Teacher>() { 
            
            new Teacher(){ID = 1, Name = "Berkin" , Gender = "Man" },
            new Teacher(){ID = 2, Name = "Sinem" , Gender = "Woman" },
            new Teacher(){ID = 3, Name = "Aslan Can" , Gender = "Man" },
            new Teacher(){ID = 4, Name = "Leyla" , Gender = "Woman" },

        };   

        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }

        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = teachers.Find(n => n.ID == id);
            return View(teacher);
        }
    }
}

