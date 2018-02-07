using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App.ViewModel
{
    public class HomePageViewModel : IPageViewModel
    {
        public Page ContentPage { get; set; }

        private HomePageModel _model;

        public HomePageViewModel(HomePageModel model)
        {
            this._model = model;
            this.ContentPage = new HomePage();
        }
    }
}
