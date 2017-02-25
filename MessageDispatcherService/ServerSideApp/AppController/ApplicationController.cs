using Microsoft.Practices.Unity;
using ServiceInterface;

namespace ServerSideApp.AppController
{
    public class ApplicationController : IApplicationController
    {
        #region IApplicationController implementation

        public ApplicationController()
        {
            _container = new UnityContainer();
            _container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterType<TType, TImplementation>()
            where TImplementation : class, TType
        {
            _container.RegisterType<TType, TImplementation>();
            return this;
        }

        public IApplicationController RegisterType<TType>()
        {
            _container.RegisterType<TType>();
            return this;
        }

        public IApplicationController RegisterInstance<TInstance>(TInstance instance)
        {
            _container.RegisterInstance<TInstance>(instance);
            return this;
        }

        public void Run<TService>()
            where TService : class, IService
        {
            if (!_container.IsRegistered<TService>())
                _container.RegisterType<TService>();

            _container.Resolve<TService>().Run();
        }

        #endregion

        #region Private fields

        private IUnityContainer _container;

        #endregion
    }
}
