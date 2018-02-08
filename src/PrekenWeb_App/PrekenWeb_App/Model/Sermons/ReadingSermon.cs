using System;
using System.Collections.Generic;
using System.Text;

namespace PrekenWeb_App.Model.Sermons
{
    public class ReadingSermon : Sermon
    {
        public string Sermon;
        public override int Type => 0;
    }
}
