using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheoryWebTask.Data;

namespace TheoryWebTask.Controllers
{
    public class BigArticlesController : Controller
    {
        private readonly TheoryDbContext _theoryDbContext;
        public BigArticlesController()
        {
            _theoryDbContext = new TheoryDbContext();
        }
        // GET: BigArticles
        public PartialViewResult AllBigArticles()
        {
            var bigArticles = _theoryDbContext.BigArticles.ToList();
            return PartialView(bigArticles);
        }
    }
}