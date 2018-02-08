using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using PrekenWeb_App.Model.Sermons;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App.ViewModel
{
    public class HomePageViewModel : IPageViewModel
    {
        public Page ContentPage { get; set; }

        public ObservableCollection<Sermon> Sermons;

        private HomePageModel _model;


        public HomePageViewModel(HomePageModel model)
        {
            this._model = model;
            Sermons = new ObservableCollection<Sermon>(_model.Sermons);
            this.ContentPage = new HomePage(this);
        }
    }
}
