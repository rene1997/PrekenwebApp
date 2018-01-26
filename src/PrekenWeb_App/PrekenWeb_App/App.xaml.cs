using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    //new PrekenWeb_App.Model.Main(this);
            MainPage = new HomePage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
