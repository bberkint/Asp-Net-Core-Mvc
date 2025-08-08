using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {

                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }


                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Entity.Tag { Text = "web programlama", Url = "web-programlama", Color = TagColors.info },
                        new Entity.Tag { Text = "backend", Url = "backend", Color = TagColors.secondary },
                        new Entity.Tag { Text = "frontend", Url = "frontend", Color = TagColors.danger },
                        new Entity.Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.success },
                        new Entity.Tag { Text = "php", Url = "php", Color = TagColors.warning }
                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "berkintopaloglu", Image = "p1.jpg" },
                        new User { UserName = "sinemeraslan", Image = "p2.jpg" }
                    );
                    context.SaveChanges();
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Asp.net Core",
                            Content = "Asp.net Core dersleri",
                            Url = "asp-net-core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpg",
                            UserId = 1,
                            Comments = new List<Comment> { new Comment { Text = "iyi bir kurs", PublishedOn = new DateTime(), UserId = 1 },
                                       new Comment { Text = "çok faydalandığım bir kurs", PublishedOn = new DateTime(), UserId = 2 },
                            }
                        },
                        new Post
                        {
                            Title = "PHP ",
                            Content = "Php Core dersleri",
                            Url = "php",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            Image = "2.jpg",
                            UserId = 1
                        },
                        new Post
                        {
                            Title = "Django",
                            Content = "Django Dersleri",
                            Url = "django",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "React",
                            Content = "React Dersleri",
                            Url = "react-dersleri",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(5).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "Angular",
                            Content = "Angular Dersleri",
                            Url = "angular",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(6).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "Web Tasarım",
                            Content = "Web Tasarım Dersleri",
                            Url = "web-tasarim",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
