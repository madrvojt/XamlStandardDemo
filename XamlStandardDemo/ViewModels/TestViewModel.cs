using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlStandardDemo.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        private string _entryText = "";

        public string EntryText {

            get 
            {
                return _entryText;
            }
            set {

                OnPropertyChanged();
                _entryText = value;
            }
        }




        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
