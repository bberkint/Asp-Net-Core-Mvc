namespace Udemy.Dependency.Services
{

    public interface ServiceBase
    {
        string GuidId { get; }
    }

    public interface ITransientService : ServiceBase
    {

    }

    public interface IScopedService : ServiceBase
    {

    }

    public interface ISingletonService : ServiceBase
    {

    }
}
