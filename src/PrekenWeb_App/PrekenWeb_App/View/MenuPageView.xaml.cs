using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrekenWeb_App.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageView : ContentPage
	{
	    public ListView MenuItems { get; set; }

        public MenuPageView ()
        {
            MenuItems = new ListView();
            //MenuItems.

			InitializeComponent ();

		}
	}
}