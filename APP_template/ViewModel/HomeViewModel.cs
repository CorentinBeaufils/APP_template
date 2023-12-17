using System;
using System.Collections.Generic;
using System.Text;
using APP_template.Model;

namespace APP_template.ViewModel
{
    class HomeViewModel : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string Name
        {
            get { return _pageModel.nom_save; }
            set {  _pageModel.nom_save = value;OnPropertyChanged(); }
        }
        public HomeViewModel()
        {
            _pageModel = new PageModel();
            Name = "home view";
        }
    }
}
