using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfDemoApp.DataAccess;

namespace WpfDemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel kernel;

        protected override void OnStartup(StartupEventArgs e)
        {
            kernel = new StandardKernel();
            kernel.Load(new IoCRegistration());

            base.OnStartup(e);
            Current.MainWindow = kernel.Get<MainWindow>(); // new MainWindow(new InMemoryProductRepository());
            Current.MainWindow.Show();
        }
    }
}
