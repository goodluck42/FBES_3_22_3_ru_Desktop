using System;

namespace FormsNMVP.Views
{
    public interface IMainView
    {
        event Action LoginButtonClicked;
        event Action RegisterButtonClicked;
        void OpenLoginView();
        void OpenRegisterView();
    }
}