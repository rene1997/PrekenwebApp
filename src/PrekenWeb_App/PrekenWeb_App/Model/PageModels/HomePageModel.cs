using System;
using System.Collections.Generic;
using System.Text;
using PrekenWeb_App.Model.Sermons;
using PrekenWeb_App.ViewModel;

namespace PrekenWeb_App.Model.PageModels
{
    public class HomePageModel : IPageModel
    {
        public IPageViewModel ViewModel { get; set; }
        public List<Sermon> Sermons { get; set; }
        
        private Main _main;

        public HomePageModel()
        {
            Sermons = new List<Sermon>();
            FillTestData();
            this.ViewModel = new HomePageViewModel(this);
        }

        public void SetMain(Main main)
        {
            this._main = main;
        }

        private void FillTestData()
        {
            Sermons.Add(new AudioSermon() {Book = "2 Korinthe 5:1",Minister = "Ds. J. Ijsselstein", PublishedDate = new DateTime(2018,02,06),SermonId = Sermons.Count,Summary = "lorem ipsum..."});
            Sermons.Add(new AudioSermon() { Book = "1 Timotheus1:15", Minister = "Ds. S.W. Janse", PublishedDate = new DateTime(2018, 02, 06), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "Numeri 21:4-9", Minister = "Ds. J. Ijsselstein", PublishedDate = new DateTime(2018, 02, 06), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "Johannes 1: 44-46", Minister = "Ds. J.S. van der Net", PublishedDate = new DateTime(2018, 02, 02), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "Johannes 1: 1-18", Minister = "Ds. C.G. Vreugdenhil", PublishedDate = new DateTime(2018, 02, 02), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "Zondag 6 ", Minister = "Ds. J. Ijsselstein", PublishedDate = new DateTime(2018, 02, 02), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "1 Koningen 19:18", Minister = "Ds. C.G. Vreugdenhil", PublishedDate = new DateTime(2018, 02, 02), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new AudioSermon() { Book = "1 Samuel 51 :8", Minister = "Ds. J. Ijsselstein", PublishedDate = new DateTime(2018, 02, 02), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new ReadingSermon() { Book = "Psalmen 51:8", Minister = "Ds. C.G. Vreugdenhil", PublishedDate = new DateTime(2018, 1, 30), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
            Sermons.Add(new ReadingSermon() { Book = "Jesaja 1 :16-18", Minister = "Ds. J. Ijsselstein", PublishedDate = new DateTime(2018, 01, 30), SermonId = Sermons.Count, Summary = "lorem ipsum..." });
        }
    }
}
