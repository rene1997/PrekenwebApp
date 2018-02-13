using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.DependencyClasses;
using PrekenWeb_App.Model.Sermons;
using PrekenWeb_App.ViewModel;
using Xamarin.Forms;


namespace PrekenWeb_App.Model.PageModels
{
    public class AudioPageModel : IPageModel
    {
        public IPageViewModel ViewModel { get; set; }

        public AudioSermon _sermon { get; set; }
        private Main _main;

        public AudioPageModel(AudioSermon sermon)
        {
            this._sermon = sermon;
            this.ViewModel = new AudioPageViewModel(this);
        }


        public void SetMain(Main main)
        {
            this._main = main;
        }

        public void PlaySermon()
        {
            DependencyService.Get<IPlaySermon>().PlayOnlineSermon(_sermon.SermonUrl);
        }

        public void StopSermon()
        {
            DependencyService.Get<IPlaySermon>().StopOnlineSermon(_sermon.SermonUrl);
        }
    }
}
