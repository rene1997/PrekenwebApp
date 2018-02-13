using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PrekenWeb_App.Model.PageModels;
using PrekenWeb_App.View;
using Xamarin.Forms;

namespace PrekenWeb_App.ViewModel
{
    public class AudioPageViewModel : IPageViewModel
    {
        public Page ContentPage { get; set; }

        public ObservableCollection<SermonDetail> SermonDetails;

        private AudioPageModel _model;

        private AudioPage _view;

        public AudioPageViewModel(AudioPageModel model)
        {
            this._model = model;
            this.SermonDetails = new ObservableCollection<SermonDetail>();
            FillData();
            

            this._view = new AudioPage(this);
            this.ContentPage = _view;
        }

        public void PlaySermon()
        {
            _model.PlaySermon();
        }

        private void FillData()
        {
            SermonDetails.Add(new SermonDetail{Title = "Voorganger:", Value = _model._sermon.Minister});
            SermonDetails.Add(new SermonDetail { Title = "Bijbelboek:", Value = _model._sermon.Book });
            SermonDetails.Add(new SermonDetail { Title = "Gemeente:", Value = "onbekend" });
            SermonDetails.Add(new SermonDetail { Title = "Gepubliceerd:", Value = _model._sermon.PublishedDate.ToLongDateString()});
            SermonDetails.Add(new SermonDetail { Title = "Over de preek:", Value = _model._sermon.Summary });
            SermonDetails.Add(new SermonDetail { Title = "Voorganger", Value = _model._sermon.Minister });
        }

        public void StopSermon()
        {
            _model.StopSermon();
        }
    }

    public class SermonDetail
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
