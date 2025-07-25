    using ConvMVVM2.Core.MVVM;
using ShowRoomDisplay.ViewModels;
using ShowRoomDisplay.Views;
using ShowRoomDisplay.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay
{
    public class BootStrapper : AppBootstrapper
    {
        protected override void OnStartUp(IServiceContainer container)
        {

        }

        protected override void RegionMapping(IRegionManager layerManager)
        {

            layerManager.Mapping<DashView>("MainContent");
            layerManager.Mapping<MainView>("MainView");

        }

        protected override void RegisterModules()
        {

        }

        protected override void RegisterServices(IServiceCollection serviceCollection)
        {

            //Windows
            serviceCollection.AddSingleton<MainWindow>();
            serviceCollection.AddSingleton<VisionWindow>();
            serviceCollection.AddSingleton<DetailWindow>();
            serviceCollection.AddInstance<CommonWindow>();


            //Views

            serviceCollection.AddSingleton<MainView>();
            serviceCollection.AddSingleton<SettingView>();
            serviceCollection.AddSingleton<DashView>();
            // serviceCollection.AddSingleton<AdminLoginView>();
            serviceCollection.AddInstance<DetailView>();


            //ViewModels
            serviceCollection.AddSingleton<MainViewModel>();
            serviceCollection.AddSingleton<SettingViewModel>();
            serviceCollection.AddSingleton<DashViewModel>();
            serviceCollection.AddSingleton<DetailViewModel>();
            serviceCollection.AddSingleton<VisionViewModel>();


            //Services


        }

        protected override void ViewModelMapping(IViewModelMapper viewModelMapper)
        {

        }
    }
}
