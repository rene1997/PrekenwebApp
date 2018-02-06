using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.ViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public class PageHandler
    {
        private Main _main;
        private MasterPageViewModel _mainPage;

        public PageHandler(Main main)
        {
            this._main = main;
            _mainPage = new MasterPageViewModel();
            main.App.MainPage = _mainPage;

        }
    }
}
