using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace ReadLater5.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class BookmarksController : Controller
    {
        private readonly IBookmarkServices bookmark;
        public BookmarksController(IBookmarkServices bookmarkServices)
        {
            bookmark = bookmarkServices;
        }
        // GET: BookmarksController
        [HttpGet("all")]
        public ActionResult Index()
        {
            List<Bookmark> model = bookmark.GetBookmarks();
            return View(model);
        }

        // GET: BookmarksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookmarksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookmarksController/Create
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

        // GET: BookmarksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookmarksController/Edit/5
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

        // GET: BookmarksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookmarksController/Delete/5
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
