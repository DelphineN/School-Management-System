using CourseReg3.Data;
using CourseReg3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseReg3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CoursesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Courses> objList = _db.Courses;
            return View(objList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Courses obj)
        {
            if (ModelState.IsValid)
            {
                _db.Courses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Courses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(Courses obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Courses.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }            

            return View(obj);

        }
        // GET Update
        public IActionResult Update(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Courses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Courses obj)
        {
            if (ModelState.IsValid)
            {
                _db.Courses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
