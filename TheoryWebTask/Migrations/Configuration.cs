namespace TheoryWebTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TheoryWebTask.Data.TheoryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheoryWebTask.Data.TheoryDbContext context)
        {
            context.Menus.AddOrUpdate(new Data.Menu
            {
                Id = 1,
                Name = "Home",
                IsActive = true,
                Order = 1
            }, new Data.Menu
            {
                Id = 2,
                Name = "Generic",
                IsActive = true,
                Order = 2
            }, new Data.Menu
            {
                Id = 3,
                Name = "Elements",
                IsActive = true,
                Order = 3
            });
            context.People.AddOrUpdate(new Data.Person
            {
                Id = 1,
                Name = "Telman",
                WorkName = "Web Developer",
                ImagePath = "pic03.jpg"
            },
            new Data.Person
            {
                Id = 2,
                Name = "Kamran",
                WorkName = "Web Developer",
                ImagePath = "pic04.jpg"
            }, new Data.Person
            {
                Id = 3,
                Name = "Teymur",
                WorkName = "Photographer",
                ImagePath = "pic05.jpg"
            }, new Data.Person
            {
                Id = 4,
                Name = "Nicat",
                WorkName = "Copy/Writer",
                ImagePath = "pic06.jpg"
            });
            context.BigArticles.AddOrUpdate(new Data.BigArticle
            {
                Id = 1,
                ImagePath = "pic01.jpg",
                Title = "Praesent placerat magna",
                ShortDescription = "Praesent dapibus, neque id cursus faucibus, tortor neque egestas augue, eu vulputate magna eros eu erat. Aliquam erat volutpat. Nam dui mi, tincidunt quis, accumsan porttitor lorem ipsum."
            }, new Data.BigArticle
            {
                Id = 2,
                ImagePath = "pic02.jpg",
                Title = "Fusce pellentesque tempus",
                ShortDescription = "Sed adipiscing ornare risus. Morbi est est, blandit sit amet, sagittis vel, euismod vel, velit. Pellentesque egestas sem. Suspendisse commodo ullamcorper magna non comodo sodales tempus."
            });
            context.LittleArticles.AddOrUpdate(new Data.LittleArticle
            {
                Id = 1,
                Title = "Magna tempus sed amet aliquam veroeros",
                ShortDescription = "Morbi interdum mollis sapien. Sed ac risus. Phasellus lacinia, magna a ullamcorper laoreet, lectus arcu."
            }, new Data.LittleArticle
            {
                Id = 2,
                Title = "Interdum lorem pulvinar adipiscing vitae",
                ShortDescription = "Morbi interdum mollis sapien. Sed ac risus. Phasellus lacinia, magna a ullamcorper laoreet, lectus arcu."
            }, new Data.LittleArticle
            {
                Id = 3,
                Title = "Libero purus magna sapien sed ullamcorper",
                ShortDescription = "Morbi interdum mollis sapien. Sed ac risus. Phasellus lacinia, magna a ullamcorper laoreet, lectus arcu."
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
