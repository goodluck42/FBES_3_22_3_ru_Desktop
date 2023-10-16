using FormsNMVP.Views;

namespace FormsNMVP.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.LoginButtonClicked += () => { _view.OpenLoginView(); };
            _view.RegisterButtonClicked += () => { _view.OpenRegisterView(); };
        }
    }
}