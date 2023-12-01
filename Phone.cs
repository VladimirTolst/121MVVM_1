using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _121MVVM_1
{
    public class Phone : INotifyPropertyChanged
    {
        private string _Name;
        private string _Surname;
        private int _Age;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return _Surname; }
            set
            {
                _Surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}