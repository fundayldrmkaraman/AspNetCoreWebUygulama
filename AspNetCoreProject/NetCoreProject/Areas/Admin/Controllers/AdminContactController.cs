using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values = contactManager.GetContacts();
            return View(values);
        }
    }
}
