using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekenWeb_App.Model.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrekenWeb_App.ViewModel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPageViewModel
	{
        public ListView ListView => listView;

	    public MasterPageViewModel ()
		{
			InitializeComponent ();
		    masterPage.Listview.ItemSelected += OnItemSelected;
            
		}

	    void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        if (e.SelectedItem is MasterPageItem item)
	        {
	            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
	            masterPage.ListView.SelectedItem = null;
	            IsPresented = false;
	        }
	    }
    }
}