using System;
using System.Collections.Generic;
using System.Text;

namespace PrekenWeb_App.Model.Sermons
{
    public class AudioSermon : Sermon
    {
        public object AudioFile;


        public override int Type => 1;
    }
}
