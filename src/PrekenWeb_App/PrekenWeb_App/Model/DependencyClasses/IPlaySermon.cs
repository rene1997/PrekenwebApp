using System;
using System.Collections.Generic;
using System.Text;

namespace PrekenWeb_App.Model.DependencyClasses
{
    public interface IPlaySermon
    {
        void PlayOnlineSermon(String url);

        void StopOnlineSermon(String url);

    }
}
