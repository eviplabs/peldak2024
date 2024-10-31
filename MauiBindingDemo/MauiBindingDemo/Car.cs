using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingDemo
{
    public class Car : INotifyPropertyChanged
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Model)));
                }
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
