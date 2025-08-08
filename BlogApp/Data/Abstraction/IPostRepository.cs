 using BlogApp.Entity;

namespace BlogApp.Data.Abstraction
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }
        void CreatePost(Post post);
    }
}
