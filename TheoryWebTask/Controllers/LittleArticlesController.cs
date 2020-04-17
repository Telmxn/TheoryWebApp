using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheoryWebTask.Data;

namespace TheoryWebTask.Controllers
{
    public class LittleArticlesController : Controller
    {
        private readonly TheoryDbContext _theoryDbContext;
        public LittleArticlesController()
        {
            _theoryDbContext = new TheoryDbContext();
        }
        // GET: LittleArticles
        public PartialViewResult AllLittleArticles()
        {
            var littleArticles = _theoryDbContext.LittleArticles.ToList();
            return PartialView(littleArticles);
        }
    }
}