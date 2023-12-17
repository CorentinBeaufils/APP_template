using System;
using System.Collections.Generic;
using System.Text;
using APP_template.Model;

namespace APP_template.ViewModel
{
    class SocketViewModel: Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string Name
        {
            get { return _pageModel.nom_save; }
            set { _pageModel.nom_save = value; OnPropertyChanged(); }
        }

        public SocketViewModel()
        {
            _pageModel = new PageModel();
            Name = "socket View model";

        }
    }
}
