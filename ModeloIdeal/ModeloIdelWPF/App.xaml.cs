
using System.Windows;
using ModeloIdeal.Application;
using ModeloIdeal.Application.Interface;
using ModeloIdeal.Domain.Interface.Repository;
using ModeloIdeal.Domain.Interface.Services;
using ModeloIdeal.Domain.Services;
using ModeloIdeal.RepositoryNH;
using ModeloIdeal.RepositoryOracle;
using Ninject;

namespace ModeloIdelWPF
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {

        private IKernel container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();
            container.Bind(typeof(IApplicationBase<>)).To(typeof(IApplicationBase<>));
            container.Bind<IContContContabilApplication>().To<ContContabilApplication>();


            container.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            container.Bind<IContContabilService>().To<ContContabilService>();
            var banco = "oracle";
            if (banco == "oracle")
            {
                container.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBaseOracle<>));
                container.Bind<IContContabilRepository>().To<ContContabilRepositoryOracle>();
            }
            else
            {
                container.Bind(typeof (IRepositoryBase<>)).To(typeof (RepositoryBase<>));
                container.Bind<IContContabilRepository>().To<ContContabilRepository>();
            }
        }

        private void ComposeObjects()
        {
            Current.MainWindow = this.container.Get<MainWindow>();
            Current.MainWindow.Title = "ModeloIdeal";
        }




    }
}
