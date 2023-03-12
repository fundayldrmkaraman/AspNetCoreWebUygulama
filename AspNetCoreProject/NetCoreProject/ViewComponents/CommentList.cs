using Microsoft.AspNetCore.Mvc;
using NetCoreProject.Models;
using System.Collections.Generic;

namespace NetCoreProject.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Funda"
                },
                 new UserComment
                {
                    ID=2,
                    UserName="Fulya"
                },
                  new UserComment
                {
                    ID=3,
                    UserName="Hülya"
                },
            };
            return View(commentvalues);
        }
    }
}
