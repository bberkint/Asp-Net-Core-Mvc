using System.Collections.Generic;

using GettingData.Models;

using Microsoft.AspNetCore.Mvc;


namespace GettingData.Controllers
{
    public class StudentController : Controller
    {

        List<Student> students = new List<Student>() { 
            new Student(){ FirstName = "Berkin", LastName = "Topaloğlu"},
            new Student(){ FirstName = "Efsa", LastName = "Topaloğlu"},
            new Student(){ FirstName = "Sinem", LastName = "Eraslan"},
            new Student(){ FirstName = "Leyla", LastName = "Topaloğlu"},
        };
        public IActionResult GetStudentList()
        {
            return View(students);
        }


        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);

            return View("GetStudentList", students);
        }
    }
}
