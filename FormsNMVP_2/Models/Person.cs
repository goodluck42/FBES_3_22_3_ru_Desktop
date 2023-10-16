using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsNMVP.Models
{
    public class Product : INotifyPropertyChanged
    {
        private int _count;
        private string _name;
        private DateTime _dateAdded;
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public int Count
        {
            get => _count;
            set => SetField(ref _count, value);
        }

        public DateTime DateAdded
        {
            get => _dateAdded;
            set => SetField(ref _dateAdded, value);
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