using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsNMVP.Presenters;
using FormsNMVP.Services;
using FormsNMVP.Views;
using Microsoft.Extensions.DependencyInjection;

namespace FormsNMVP
{
    
    public static class Program
    {
        private static ServiceCollection s_ServiceCollection;
        private static ServiceProvider s_ServiceProvider;
        
        [STAThread]
        public static void Main()
        {
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            }
            
            RegisterServices();
            
            
            // discard 
            _ = s_ServiceProvider.GetService<IMainPresenter>();
            
            var view = s_ServiceProvider.GetService<IMainView>();

            // non cross platform
            {
                Application.Run(view as Form);
            }
        }

        private static void RegisterServices()
        {
            s_ServiceCollection = new ServiceCollection();

            s_ServiceCollection.AddSingleton<IUserStorage, FileUserStorage>();
            s_ServiceCollection.AddSingleton<IProductStorage, FileProductStorage>();
            s_ServiceCollection.AddSingleton<ProductFactory>();
            s_ServiceCollection.AddSingleton<IMainView, MainView>();
            s_ServiceCollection.AddSingleton<IMainPresenter, MainPresenter>();
            
            s_ServiceProvider = s_ServiceCollection.BuildServiceProvider();
        }
    }
}