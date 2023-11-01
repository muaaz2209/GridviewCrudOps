using GridviewCrudOps;
using GridviewCrudOps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GridviewCrudOps.Controllers
{
    public class CompaniesController : Controller
    {
        private YourDbContext _context = new YourDbContext(); // Create an instance of your DbContext

        // GET: Companies
        public ActionResult Index()
        {
            var companies = _context.Company3.ToList();
            return View(companies);
        }

        // GET: Companies/Details/5
        public ActionResult Details(int id)
        {
            var companies = _context.Company.Find(id);
            return View(companies);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Company3 company)
        {
            if (ModelState.IsValid)
            {
                _context.Company3.Add(company);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Edit/5 
        public ActionResult Edit(int id)
        {
            var company = _context.Company3.Find(id);
            return View(company);
        }

        [HttpPost]
        public ActionResult Edit(Company3 company)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(company).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Delete
        public ActionResult Delete(int id)
        {
            var company = _context.Company3.Find(id);
            return View(company);
        }

        [HttpPost]
        public ActionResult Delete(Company3 company)
        {
            //var company = _context.Company3.Find(id);
            _context.Company3.Remove(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}