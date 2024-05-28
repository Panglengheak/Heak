using Microsoft.AspNetCore.Mvc;
using LMS.Models;
using LMS.Services;

namespace LMS.Controllers
{
    public class LibrarianController : Controller
    {
        private readonly ILibrarianService _service;
        public LibrarianController(ILibrarianService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var librarians = await _service.GetAll();
            return View("Index", librarians);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Store(Librarian librarian)
        {
            if (!ModelState.IsValid)
            {
                return View(librarian);
            }
            if (await _service.Create(librarian))
            {
                return RedirectToAction("Index");
            }
            return View(librarian);
        }
        
        [HttpGet]
        public async Task<IActionResult> Edit(int LibrarianId)
        {
            var lms = await _service.GetById(LibrarianId);
            return View("Edit", lms);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Librarian librarian)
        {
            if (!ModelState.IsValid)
            {
                return View(librarian);
            }
            if (await _service.Update(librarian))
            {
                return RedirectToAction("Index");
            }
            return View(librarian);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int LibrarianId)
        {
            var librarian = await _service.GetById(LibrarianId);
            return View("Delete", librarian);
        }
        [HttpPost]
        public async Task<IActionResult> Destroy(Librarian librarian)
        {
            if (!ModelState.IsValid)
            {
                return View(librarian);

            }
            if (await _service.Delete(librarian))
            {
                return RedirectToAction("Index");
            }
            return View(librarian);
        }
    }
}
