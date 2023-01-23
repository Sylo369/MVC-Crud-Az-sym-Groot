using MVC_Crud_Az_sym_Groot.Context;
using MVC_Crud_Az_sym_Groot.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Crud_Az_sym_Groot.Controllers
{
    public class BlogController : Controller
    {
        BlogContext db;
        public BlogController(BlogContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Blogs> Blogs = db.Blogs.Select(b => b).ToList();
            return View(Blogs);
        }
        public IActionResult Delete(int id)
        {
            Blogs Blogs = db.Blogs.FirstOrDefault(b => b.BlogId == id);
            if (id != null)
            {
                db.Remove(Blogs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}