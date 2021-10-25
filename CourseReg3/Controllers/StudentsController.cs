using CourseReg3.Data;
using CourseReg3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseReg3.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Students> objList = _db.Students;
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
        public IActionResult Create(Students obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
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
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET Update
        public IActionResult Update(int? id)
        {
            

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Students obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
