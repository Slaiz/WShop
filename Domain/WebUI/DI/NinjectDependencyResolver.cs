using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Domain.Repository;
using Domain.Concrete;
using Moq;
using Domain.Model;

namespace WebUI.DI
{
    /// <summary>
    /// Class for DI-container
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel _kernel)
        {
            this._kernel = _kernel;
            AddBindings();
        }

        private void AddBindings()
        {
            //Mock<IGameRepository> mock = new Mock<IGameRepository>();

            //mock.Setup(m => m.Games).Returns(new List<Game>
            //{
            //    new Game { Name = "asd", Publisher="ds", MainPlatform="as", Genre="asd", Description="s", Price=76}
            //});

            //_kernel.Bind<IGameRepository>().ToConstant(mock.Object);
            _kernel.Bind<IGameRepository>().To<EFGameRepository>();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}