using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.ViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public class HomePageModel : IPageModel
    {
        public IPageViewModel ViewModel { get; set; }
        
        private Main _main;

        public HomePageModel()
        {
            this.ViewModel = new HomePageViewModel(this);
        }

        public HomePageModel(Main main)
        {
            this._main = main;
            this.ViewModel = new HomePageViewModel(this);
        }

        public void SetMain(Main main)
        {
            this._main = main;
        }
    }
}
