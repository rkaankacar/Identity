using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IdentityApp.Controllers
{     
    public class UsersController : Controller
    {    private UserManager<IdentityUser> userManager;
        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}