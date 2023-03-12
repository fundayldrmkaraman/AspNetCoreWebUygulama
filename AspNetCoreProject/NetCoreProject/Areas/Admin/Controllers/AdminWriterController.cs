using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminWriterController : Controller
    {

        WriterManager writerManager=new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var values = writerManager.GetWriterWithNumber();
            return View(values);
        }

    }
}
