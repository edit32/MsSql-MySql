using MsSql_MySql.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql_MySql.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {   
        private string textAreaValue;
        public string TextAreaValue
        {
            get { return textAreaValue; }
            set
            {
                if (textAreaValue != value)
                {
                    textAreaValue = value;
                    OnPropertyChanged(nameof(TextAreaValue));
                }
            }
        }

        private List<gi_comuni_validita> _listaComuniMS;
        public List<gi_comuni_validita> ListaComuniMS
        {
            get { return _listaComuniMS; }
            set
            {
                if (_listaComuniMS == value) return;
                _listaComuniMS = value;
                OnPropertyChanged(nameof(ListaComuniMS));
            }
        }

        private List<gi_comuni_validita> _listaComuniMY;
        public List<gi_comuni_validita> ListaComuniMY
        {
            get { return _listaComuniMY; }
            set
            {
                if (_listaComuniMY == value) return;
                _listaComuniMY = value;
                OnPropertyChanged(nameof(ListaComuniMY));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
