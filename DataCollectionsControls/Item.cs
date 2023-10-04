using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataCollectionsControls
{
    public class Item : INotifyPropertyChanged
    {
        private string _name;
        private int _quantity;
        private string _cat;

        public Item()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        }

        public int Quantity
        {
            get => _quantity;
            set => SetField(ref _quantity, value);
        }

        public string Cat
        {
            get => _cat;
            set => SetField(ref _cat, value);
        }

        public string DisplayMember => $"{Name}: {Quantity} | {Cat}";
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