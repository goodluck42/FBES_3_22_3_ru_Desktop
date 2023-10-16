using System;
using System.Windows.Forms;

namespace FormsNMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event Action LoginButtonClicked;
        public event Action RegisterButtonClicked;
        
        public void OpenLoginView()
        {
            var form = new LoginView();

            form.ShowDialog();
        }

        public void OpenRegisterView()
        {
            var form = new RegisterView();

            form.ShowDialog();
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            LoginButtonClicked?.Invoke();
        }

        private void _registerButton_Click(object sender, EventArgs e)
        {
            RegisterButtonClicked?.Invoke();
        }
    }
}