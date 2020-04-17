using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheoryWebTask.Data;

namespace TheoryWebTask.Controllers
{
    public class PeopleController : Controller
    {
        private readonly TheoryDbContext _theoryDbContext;
        public PeopleController()
        {
            _theoryDbContext = new TheoryDbContext();
        }
        // GET: People
        public PartialViewResult AllPeople()
        {
            var people = _theoryDbContext.People.ToList();
            return PartialView(people);
        }
    }
}