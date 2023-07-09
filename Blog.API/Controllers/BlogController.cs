using AutoMapper;
using Blog.API.Models;
using Blog.Domain.DTO;
using Blog.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    public class BlogController : Controller
    {
        //private readonly IHttpContextAccessor _contextAccessor;
        private readonly IBlogServices Databases;
        private readonly IMapper Mapper;
        public BlogController(IBlogServices database, IMapper mapper)
        {
            Databases = database;
            Mapper = mapper;
        }
        // GET: BlogController
        [HttpGet]
        [Route("/List")]
        public ActionResult List()
        {
            var db = Databases.GetAllBlogs();
            var mp = Mapper.Map<IEnumerable<BlogDTO>, IEnumerable<BlogVM>>(db);
            return View(mp);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
