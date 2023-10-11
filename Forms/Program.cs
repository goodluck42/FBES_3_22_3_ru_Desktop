using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Forms
{
    static class Program
    {
        private static ServiceCollection s_Collection;

        private static ServiceProvider s_Provider;

        // Microsoft.Extensions.DependencyInjection
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                s_Collection = new ServiceCollection();

                s_Collection.AddSingleton<MainForm>();
                s_Collection.AddSingleton<IPersonManager, PersonManager>();

                s_Provider = s_Collection.BuildServiceProvider();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var mainForm = s_Provider.GetService<MainForm>();

                if (mainForm != null)
                {
                    Application.Run(mainForm);
                }
            }
        }
    }
}