﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekenWeb_App.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrekenWeb_App.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
	    public ListView SermonsView => sermonsView;
        private HomePageViewModel _viewModel;
	    

        public HomePage (HomePageViewModel viewModel)
		{
		    this._viewModel = viewModel;
			InitializeComponent ();
		    sermonsView.ItemsSource = viewModel.Sermons;
        }

	    public void RefreshListView()
	    {
	        sermonsView.ItemsSource = null;
            sermonsView.ItemsSource = _viewModel.Sermons;
        }


	}
}