using System;
using System.Windows.Forms;
using FormsNMVP.Models;

namespace FormsNMVP.Views
{
    public partial class RegisterView : Form, IRegisterView
    {
        public RegisterView()
        {
            InitializeComponent();

            _genderComboBox.Items.Add(Gender.Male);
            _genderComboBox.Items.Add(Gender.Female);
            _genderComboBox.Items.Add(Gender.Other);
        }

        public string Login => _loginTextBox.Text;

        public string Password => _passwordTextBox.Text;

        public Gender SelectedGender => (Gender)_genderComboBox.SelectedItem;

        public event Action RegisterButtonClicked;
    }
}