﻿using BlogApp.Data.Abstraction;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {

        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index(string tag)
        {
            var posts = _postRepository.Posts;  

            if (!string.IsNullOrEmpty(tag))
            {
                posts = posts.Where(x => x.Tags.Any(t => t.Url == tag));   
            }

            return View( new PostsViewModel {Posts = await posts.ToListAsync() }); 
        }


        public async Task<IActionResult> Details(string url)
        {
            var post = await _postRepository.Posts.Include(x => x.Tags).Include(x => x.Comments).FirstOrDefaultAsync(p => p.Url == url);
           
            return View(post);
        }
    }
}
