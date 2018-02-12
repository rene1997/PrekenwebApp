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

        private HomePage _view;


        public HomePageViewModel(HomePageModel model)
        {
            this._model = model;
            Sermons = new ObservableCollection<Sermon>(_model.Sermons);
            
            this._view = new HomePage(this);
            this.ContentPage = _view;
            _view.RefreshListView();
            _view.SermonsView.ItemSelected += SermonsViewOnItemSelected;
        }

        private void SermonsViewOnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Sermon;
            if (item != null)
            {
                if (item.Type == 1)
                {
                    _model.ViewSermon(item);
                }
                _view.SermonsView.SelectedItem = null;
            }
        }
    }
}
