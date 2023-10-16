using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsNMVP.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _login;
        private string _passwordHash;
        private Gender _gender;
        public int Id { get; set; }

        public string Login
        {
            get => _login;
            set => SetField(ref _login, value);
        }

        public string PasswordHash
        {
            get => _passwordHash;
            set => SetField(ref _passwordHash, value);
        }

        public Gender Gender
        {
            get => _gender;
            set => SetField(ref _gender, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}