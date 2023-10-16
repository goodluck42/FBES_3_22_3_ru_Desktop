using System;
using FormsNMVP.Models;

namespace FormsNMVP.Views
{
    public interface IRegisterView
    {
        string Login { get; }
        string Password { get; }
        Gender SelectedGender { get; }

        event Action RegisterButtonClicked;
    }
}