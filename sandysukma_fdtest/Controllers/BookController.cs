using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sandysukma_fdtest.Data;
using sandysukma_fdtest.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace sandysukma_fdtest.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string search, string sortBy, int page = 1)
        {
            int pageSize = 5;
            var query = _context.Books.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(b => b.Title.Contains(search) || b.Author.Contains(search));
            }

            ViewBag.CurrentSort = sortBy;
            ViewBag.SortByTitle = sortBy == "Title" ? "title_desc" : "Title";
            ViewBag.SortByAuthor = sortBy == "Author" ? "author_desc" : "Author";

            query = sortBy switch
            {
                "Title" => query.OrderBy(b => b.Title),
                "title_desc" => query.OrderByDescending(b => b.Title),
                "Author" => query.OrderBy(b => b.Author),
                "author_desc" => query.OrderByDescending(b => b.Author),
                _ => query.OrderBy(b => b.Id)
            };

            int totalBooks = await query.CountAsync();
            var books = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalBooks / pageSize);
            ViewBag.SearchQuery = search;

            return View(books);
        }


        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection form, IFormFile ThumbnailUrl)
        {
            var title = form["Title"];
            var author = form["Author"];
            if (string.IsNullOrWhiteSpace(title))
            {
                TempData["ErrorMessage"] = "Judul tidak boleh kosong.";
                return RedirectToAction("Create");
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                TempData["ErrorMessage"] = "Penulis tidak boleh kosong.";
                return RedirectToAction("Create");
            }

            var book = new Book
            {
                Title = title,
                Author = author,
                Description = form["Description"],
                Rating = int.Parse(form["Rating"])
            };

            if (ThumbnailUrl != null && ThumbnailUrl.Length > 0)
            {
                var uploadsFolder = Path.Combine("wwwroot", "uploads");

                // Pastikan folder ada
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = Path.GetFileName(ThumbnailUrl.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ThumbnailUrl.CopyToAsync(stream);
                }

                book.ThumbnailUrl = "/uploads/" + fileName;

            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Buku berhasil ditambahkan.";
            return RedirectToAction("Index");
        }



        public IActionResult Edit(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, IFormCollection form, IFormFile ThumbnailUrl)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();

            var title = form["Title"];
            var author = form["Author"];
            if (string.IsNullOrWhiteSpace(title))
            {
                ViewBag.ErrorMessage = "Judul tidak boleh kosong.";
                return View(book); 
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                ViewBag.ErrorMessage = "Penulis tidak boleh kosong.";
                return View(book); 
            }




            book.Title = title;
            book.Author = author;
            book.Description = form["Description"];
            book.Rating = int.Parse(form["Rating"]);

            if (ThumbnailUrl != null && ThumbnailUrl.Length > 0)
            {
                var fileName = Path.GetFileName(ThumbnailUrl.FileName);
                var filePath = Path.Combine("wwwroot/uploads", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ThumbnailUrl.CopyToAsync(stream);
                }
                book.ThumbnailUrl = "/uploads/" + fileName;
            }

            _context.Update(book);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Buku berhasil diupdate.";
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }

        [HttpPost]
        [Route("Book/DeleteConfirmed/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                TempData["ErrorMessage"] = "Buku tidak ditemukan.";
                return RedirectToAction("Index");
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Buku berhasil dihapus.";
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }
    }

}