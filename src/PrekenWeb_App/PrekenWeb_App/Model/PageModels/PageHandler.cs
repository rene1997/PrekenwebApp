using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using PrekenWeb_App.View;
using Xamarin.Forms;
using MasterPageViewModel = PrekenWeb_App.ViewModel.MasterPageViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public class PageHandler
    {
        private Main _main;
        private MasterPageViewModel _mainPage;
        private MenuPage _menu;
        private IPageModel _detailPage;

        public PageHandler(Main main)
        {
            this._main = main;
            this._menu = new MenuPage();
            _menu.ListView.ItemSelected += OnItemSelected;
            this._detailPage = new HomePageModel();
            _detailPage.SetMain(_main);
            
            _mainPage = new MasterPageViewModel(_menu,_detailPage);
            main.App.MainPage = _mainPage;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                IPageModel model = (IPageModel) Activator.CreateInstance(item.TargetType);
                model.SetMain(_main);
                _mainPage.SetDetailPage(model);
                //change page and hide menu
                _menu.ListView.SelectedItem = null;
                
            }
        }
    }
}
