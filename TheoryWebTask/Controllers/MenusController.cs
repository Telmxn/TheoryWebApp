using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheoryWebTask.Data;

namespace TheoryWebTask.Controllers
{
    public class MenusController : Controller
    {
        private readonly TheoryDbContext _theoryDbContext;
        public MenusController()
        {
            _theoryDbContext = new TheoryDbContext();
        }
        // GET: Menus
        public PartialViewResult AllMenus()
        {
            var menus = _theoryDbContext.Menus.Where(x => x.IsActive == true).ToList();
            return PartialView(menus);
        }
    }
}