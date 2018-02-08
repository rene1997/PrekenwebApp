using System;
using System.Collections.Generic;
using System.Text;

namespace PrekenWeb_App.Model.Sermons
{
    public abstract class Sermon
    {
        public int SermonId { get; set; }
        public DateTime PublishedDate { get; set; }
        public String Minister { get; set; }
        public String Book { get; set; }
        public String Summary { get; set; }
        public abstract int Type { get;}
    }
}
