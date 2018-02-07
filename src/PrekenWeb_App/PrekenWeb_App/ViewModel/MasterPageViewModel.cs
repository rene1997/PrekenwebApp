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

        public MasterPageViewModel(MenuPage menu, IPageModel detailModel)
        {
            Title = "Home Page";
            _menu = menu;
            Master = _menu;
            Detail = new NavigationPage(detailModel.ViewModel.ContentPage);
            
        }

        public void SetDetailPage(IPageModel detailModel)
        {
            Detail = new NavigationPage(detailModel.ViewModel.ContentPage);
            IsPresented = false;
        }

    }
}
