using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using W5.DataContext;
using W5.Models;

namespace W5.Controllers
{

    
    public class StudentController : Controller
    {

        private IDataContext _dataContext;

        public StudentController(IDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View(_dataContext.GetStudents());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dataContext.GetStudent(id));
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel student)
        {
            try
            {
                if (ModelState.IsValid)
                    _dataContext.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dataContext.GetStudent(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentViewModel student)
        {
            try
            {
                if (ModelState.IsValid)
                    _dataContext.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(_dataContext.GetStudents());
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentViewModel student)
        {
            try
            {
                _dataContext.RemoveStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
