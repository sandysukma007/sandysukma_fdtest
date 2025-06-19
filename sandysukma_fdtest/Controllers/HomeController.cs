using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using sandysukma_fdtest.Models;
using sandysukma_fdtest.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace sandysukma_fdtest.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //public IActionResult Index(string search, string filter)
        //{
        //    var users = _userManager.Users.AsQueryable();

        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        users = users.Where(u => u.UserName.Contains(search) || u.Email.Contains(search));
        //    }

        //    if (filter == "verified")
        //    {
        //        users = users.Where(u => u.EmailConfirmed);
        //    }
        //    else if (filter == "unverified")
        //    {
        //        users = users.Where(u => !u.EmailConfirmed);
        //    }

        //    var userList = users.Select(u => new UserListViewModel
        //    {
        //        Name = u.UserName,
        //        Email = u.Email,
        //        EmailConfirmed = u.EmailConfirmed
        //    }).ToList();

        //    return View(userList);
        //}


        public IActionResult Index()
        {
            return View();
        }
    }
}
