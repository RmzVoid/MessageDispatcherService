using ServiceInterface;

namespace ServerSideApp.AppController
{
    public interface IApplicationController
    {
        IApplicationController RegisterType<TType, TImplementation>()
            where TImplementation : class, TType;

        IApplicationController RegisterType<TType>();

        IApplicationController RegisterInstance<TInstance>(TInstance instance);

        void Run<TService>()
            where TService : class, IService;
    }
}
