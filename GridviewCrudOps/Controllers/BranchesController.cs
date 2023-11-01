using GridviewCrudOps;
using GridviewCrudOps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GridviewCrudOps.Controllers
{
    public class BranchesController : Controller
    {
        private YourDbContext _context = new YourDbContext(); // Create an instance of your DbContext

        // GET: Branches
        public ActionResult Index()
        {
            var branches = _context.Branches.ToList();
            return View(branches);
        }

        // GET: Branches/Details/5
        public ActionResult Details(int id)
        {
            var branch = _context.Branches.Find(id);
            return View(branch);
        }

        // GET: Branches/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Branch2 branch)
        {
            if (ModelState.IsValid)
            {
                _context.Branches.Add(branch);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branch);
        }

        // GET: Branches/Edit/5
        public ActionResult Edit(int id)
        {
            var branch = _context.Branches.Find(id);
            return View(branch);
        }

        [HttpPost]
        public ActionResult Edit(Branch2 branch)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(branch).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branch);
        }

        // GET: Branches/Delete/5
        public ActionResult Delete(int id)
        {
            var branch = _context.Branches.Find(id);
            return View(branch);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var branch = _context.Branches.Find(id);
            _context.Branches.Remove(branch);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
