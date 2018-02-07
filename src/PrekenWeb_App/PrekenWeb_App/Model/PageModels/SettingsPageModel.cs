using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.ViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public class SettingsPageModel : IPageModel
    {
        public IPageViewModel ViewModel { get; set; }
        
        private Main _main;

        public SettingsPageModel()
        {
            this.ViewModel = new SettingsPageViewModel(this);
        }

        public void SetMain(Main main)
        {
            this._main = main;
        }
    }
}
