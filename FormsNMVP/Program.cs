using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsNMVP.Presenters;
using FormsNMVP.Views;
using Newtonsoft.Json;

namespace FormsNMVP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var view = new MainView();
            var presenter = new MainPresenter(view);
            
            Application.Run(view);
        }
    }
}