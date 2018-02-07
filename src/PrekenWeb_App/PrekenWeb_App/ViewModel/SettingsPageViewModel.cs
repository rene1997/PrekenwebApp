using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App.ViewModel
{
    public class SettingsPageViewModel : IPageViewModel
    {
        public Page ContentPage { get; set; }

        private SettingsPageModel _model;

        public SettingsPageViewModel(SettingsPageModel model)
        {
            this._model = model;
            this.ContentPage = new SettingsPage(this);
        }
    }
}
