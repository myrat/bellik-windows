using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellik
{
    class Titles : INotifyPropertyChanged
    {
        private string _Title;
        private string _Fname;
        private string _Date;
        private string _LastMod;

        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Fname
        {
            get { return _Fname; }
            set
            {
                if (_Fname != value)
                {
                    _Fname = value;
                    OnPropertyChanged("File name");
                }
            }
        }

        public string Date
        {
            get { return _Date; }
            set
            {
                if (_Date != value)
                {
                    _Date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        //public string CityZip { get { return Zip.ToString() + " " + Date; } }

        public override string ToString()
        {
            return Title + "," + Date;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyTitle)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyTitle));
            }
        }

        #endregion
    }
}