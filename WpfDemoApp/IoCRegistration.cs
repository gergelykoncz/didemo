using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemoApp.DataAccess;

namespace WpfDemoApp
{
    public class IoCRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<MainWindow>().ToSelf();
            Bind<IProductRepository>()
                .To<InMemoryProductRepository>().InTransientScope();
        }
    }
}
