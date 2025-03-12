using BlogApp.Entity;

namespace BlogApp.Data.Abstraction
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }
        void CreateTag(Tag tag);
    }
}
