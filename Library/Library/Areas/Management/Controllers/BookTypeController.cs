using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
    {

        IRepository<BookType> _repoBookType;
        public BookTypeController(IRepository<BookType> repoBookType)
        {
            _repoBookType = repoBookType;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _repoBookType.GetAll();
            return View(bookTypes);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {

            _repoBookType.Add(bookType);

            return RedirectToAction("BookTypeList", "BookType", new { area="Management"});
        }


        public IActionResult Edit(int id)
        {
            var x = _repoBookType.GetById(id);

            return View(x);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _repoBookType.Update(bookType);

            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {

            _repoBookType.SpecialDelete(id);

            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

    }
}
