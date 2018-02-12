using System;
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
	public partial class AudioPage : ContentPage
	{
	    public ListView SermonDetails => sermonDetails;
	    private AudioPageViewModel _viewModel;

		public AudioPage (AudioPageViewModel viewModel)
		{
		    this._viewModel = viewModel;
			InitializeComponent ();
		    sermonDetails.ItemsSource = _viewModel.SermonDetails;
		}

	    public void RefreshListView()
	    {
	        sermonDetails.ItemsSource = null;
	        sermonDetails.ItemsSource = _viewModel.SermonDetails;
	    }
	}
}