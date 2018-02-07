using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using Xamarin.Forms;

namespace PrekenWeb_App.View
{
	public class MenuPage : ContentPage
	{
	    public ListView ListView => _listView;

	    private ListView _listView;

		public MenuPage ()
		{
		    var masterPageItems = new List<MasterPageItem>();
		    masterPageItems.Add(new MasterPageItem
		    {
		        Title = "Home",
		        IconSource = "home.png",
		        TargetType = typeof(HomePageModel)
		    });

		    masterPageItems.Add(new MasterPageItem
		    {
		        Title = "Instellingen",
		        IconSource = "settings.png",
		        TargetType = typeof(SettingsPageModel)
		    });


            _listView = new ListView
		    {
		        ItemsSource = masterPageItems,
		        ItemTemplate = new DataTemplate(() =>
		        {
		            var grid = new Grid { Padding = new Thickness(5, 10) };
		            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
		            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

		            var image = new Image();
		            image.SetBinding(Image.SourceProperty, "IconSource");
		            var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
		            label.SetBinding(Label.TextProperty, "Title");

		            grid.Children.Add(image);
		            grid.Children.Add(label, 1, 0);

		            return new ViewCell { View = grid };
		        }),
		        SeparatorVisibility = SeparatorVisibility.None
		    };

		    Icon = "menu.png";
		    Title = "Menu";
		    Padding = new Thickness(0, 40, 0, 0);
		    Content = new StackLayout
		    {
                Children = { 
                    new Image{Source = "logo.png", HorizontalOptions = LayoutOptions.CenterAndExpand},
                    _listView 
                }
		    };


        }
	}
}