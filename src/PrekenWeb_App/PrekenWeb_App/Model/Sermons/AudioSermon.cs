using System;
using System.Collections.Generic;
using System.Text;

namespace PrekenWeb_App.Model.Sermons
{
    public class AudioSermon : Sermon
    {
        public object AudioFile;
        public string SermonUrl = "http://www.prekenweb.nl/nl/Preek/Download/22737?inline=False";


        public override int Type => 1;
    }
}
