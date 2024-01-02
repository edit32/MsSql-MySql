using MsSql_MySql.Data;
using MsSql_MySql.Helper;
using MsSql_MySql.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MsSql_MySql.ViewModels
{
    public class MainWindowViewModel : BaseWindowViewModel
    {
        private MainWindow _mainWindow;
        public DelegateCommand LoadMsComuniCommand { get; }
        public DelegateCommand LoadMyComuniCommand { get; }

        public MainWindowViewModel(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;

            LoadMsComuniCommand = new DelegateCommand(o => LoadMsComuni(), o => true);
            LoadMyComuniCommand = new DelegateCommand(o => LoadMyComuni(), o => true);
        }

        private string textAreaValue;
        public string TextAreaValue
        {
            get { return textAreaValue; }
            set
            {
                if (textAreaValue != value)
                {
                    textAreaValue = value;
                    NotifyPropertyChanged("TextAreaValue");
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
                NotifyPropertyChanged("ListaComuniMS");
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
                NotifyPropertyChanged("ListaComuniMY");
            }
        }        

        public async void LoadMsComuni()
        {
            using (new WaitCursor(_mainWindow))
            {
                TextAreaValue = "Caricamento Comuni MSSQL";
                MsSqlDataReader msdr = new MsSqlDataReader();
                ListaComuniMS = await msdr.GetMsComuni();
            }
                
        }

        public async void LoadMyComuni()
        {
            using (new WaitCursor(_mainWindow))
            {
                TextAreaValue = "Caricamento Comuni MYSQL";
                MySqlDataReader mydr = new MySqlDataReader();
                ListaComuniMY = await mydr.GetMyComuni();
            }
        }
       
    }
}
