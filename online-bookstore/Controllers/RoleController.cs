using System;
using System.Linq;
using System.Web.Mvc;
using online_bookstore.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace online_bookstore.Models
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        // Get All Roles
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        // New role

        public ActionResult Create()
        {
            var Roles = new IdentityRole();
            return View(Roles);
        }

        // New Role
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}