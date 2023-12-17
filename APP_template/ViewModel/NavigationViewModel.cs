using System;
using System.Collections.Generic;
using System.Text;
using APP_template.Model;
using System.Windows.Input;
using APP_template.Utilities;

namespace APP_template.ViewModel
{
    class NavigationViewModel : Utilities.ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        

        public ICommand HomeCommand { get; set; }
        public ICommand SaveCommand { get; set;}
        public ICommand SettingCommand { get; set; }
        public ICommand SocketCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void Save(object obj) => CurrentView = new SaveViewModel();
        private void Setting(object obj) => CurrentView = new SettingViewModel();
        private void Socket(object obj) => CurrentView = new SocketViewModel();

        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            SaveCommand = new RelayCommand(Save);
            SettingCommand = new RelayCommand(Setting);
            SocketCommand = new RelayCommand(Socket);

            //page de demarage
            CurrentView = new HomeViewModel();
        }

    }
}
