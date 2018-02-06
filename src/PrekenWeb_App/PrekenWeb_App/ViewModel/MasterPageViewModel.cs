using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App.ViewModel
{
    public partial class MasterPageViewModel : MasterDetailPage
    {
        private MenuPage _menu;

        public MasterPageViewModel()
        {
            Title = "Home Page";
            _menu = new MenuPage();
            Master = _menu;
            Detail = new NavigationPage(new HomePage());
            _menu.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                //change page and hide menu
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                _menu.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}
