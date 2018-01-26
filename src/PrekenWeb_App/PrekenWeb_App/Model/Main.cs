using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using Xamarin.Forms;

namespace PrekenWeb_App.Model
{
    public class Main
    {
        public App App => _app;
        private App _app;
        private PageHandler _pageHandler;

        public Main(App app)
        {
            this._app = app;
            _pageHandler = new PageHandler(this); 
        }

        public void SetMainPage(Page page)
        {
            _app.MainPage = page;
        }
    }
}
