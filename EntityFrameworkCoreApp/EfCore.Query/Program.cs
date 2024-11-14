using EfCore.Query.Data.Context;
using EfCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCore.Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogContext();
            //context.Add(new Blog
            //{
            //    Title = "Blog1",
            //    Url ="bbt.com1"
            //});

            //context.Add(new Blog
            //{
            //    Title = "Blog2",
            //    Url = "bbt.com2"
            //});

            //context.Add(new Blog
            //{
            //    Title = "Blog3",
            //    Url = "bbt.com3"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog4",
            //    Url = "bbt.com4"
            //});
            //context.SaveChanges();

            //var query = context.Blogs.AsQueryable();

            //var blogs = query.Where(x=>x.Title.Contains("Blog1")||x.Title.Contains("Blog2")).AsEnumerable();

            //var blogs2 = blogs.Where(x => x.Title == "Blog1");

            //foreach (var item in blogs2) {
            //    Console.WriteLine(item.Title);
            //}

            //var updatedBlog = context.Blogs.SingleOrDefault(x => x.Id == 1);
            //updatedBlog.Title = "Güncellendi";

            //var updatedBlogState = context.Entry(updatedBlog).State;


            //var updatedBlog = context.Blogs.AsNoTracking().SingleOrDefault(x => x.Id == 2); // assnotr.. ile bu kaydı izleme demek istiyoruz
            //updatedBlog.Title = "Güncellendi";

            //var updatedBlogState = context.Entry(updatedBlog).State;

            // lazy, eager, explicit


            //var blogs = context.Blogs.Include(x=>x.Comments.Where(x => x.Content.Contains("Yorum1"))).ToList();

            //foreach (var blog in blogs)
            //{
            //    Console.WriteLine($"{blog.Title} blogun yorumları");
            //    foreach (var comment in blog.Comments)
            //    {
            //        Console.WriteLine($"\t\t{comment.Content} ");
            //    }
            //}

            var blog = context.Blogs.SingleOrDefault(x => x.Id == 1);
            context.Entry(blog).Collection(x => x.Comments).Load();

            foreach (var item in blog.Comments)
            {
                Console.WriteLine(item.Content);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
