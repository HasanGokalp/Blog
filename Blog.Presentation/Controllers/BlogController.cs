using AutoMapper;
using Blog.Domain.DTO;
using Blog.Domain.Services;
using Blog.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers
{
    public class BlogController : Controller
    {
        protected IBlogServices BlogServices { get; set; }
        protected IMapper Mapper { get; set; }

        public BlogController(IMapper mapper, IBlogServices blogServices)
        {
            BlogServices = blogServices;
            Mapper = mapper;
        }
        // GET: BlogController
        [HttpGet]
        [Route("Blog/List")]
        public ActionResult Index()
        {
            var services = BlogServices.GetAllBlogs();
            var mapper = Mapper.Map<IEnumerable<BlogDTO>, IEnumerable<BlogVM>>(services);
            return View(mapper);
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
