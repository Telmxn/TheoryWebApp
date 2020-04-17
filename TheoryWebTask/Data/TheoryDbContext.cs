using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheoryWebTask.Data
{
    public class TheoryDbContext : DbContext
    {
        public TheoryDbContext() : base("myTheoryDbConnection") { }
        public DbSet<Person> People { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<LittleArticle> LittleArticles { get; set; }
        public DbSet<BigArticle> BigArticles { get; set; }
    }
}