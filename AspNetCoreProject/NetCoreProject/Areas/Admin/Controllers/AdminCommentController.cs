using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace NetCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager=new CommentManager(new EfCommentRepository());    
        public IActionResult Index()
        {
            var values = commentManager.GetCommentWithBlog();
            return View(values);    
        }
    }
}
