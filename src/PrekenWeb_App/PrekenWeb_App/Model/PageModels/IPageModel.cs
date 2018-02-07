using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.ViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public interface IPageModel
    {
        IPageViewModel ViewModel { get; set; }
        void SetMain(Main main);
    }
}
