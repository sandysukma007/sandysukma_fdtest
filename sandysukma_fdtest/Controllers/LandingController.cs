using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sandysukma_fdtest.Data;
using sandysukma_fdtest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace sandysukma_fdtest.Controllers
{
    [AllowAnonymous]
    public class LandingController : Controller
    {
        private readonly AppDbContext _context;
        public LandingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchAuthor, int? rating, string date, int page = 1)
        {
            int pageSize = 5;
            var books = _context.Books.AsQueryable();

            if (!string.IsNullOrEmpty(searchAuthor))
                books = books.Where(b => b.Author.Contains(searchAuthor));

            if (rating.HasValue)
                books = books.Where(b => b.Rating == rating);

            if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out DateTime filterDate))
                books = books.Where(b => b.UploadedAt.Date == filterDate.Date);

            var totalItems = await books.CountAsync();
            var pagedBooks = await books
                .OrderByDescending(b => b.UploadedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return View(pagedBooks);
        }
    }

}