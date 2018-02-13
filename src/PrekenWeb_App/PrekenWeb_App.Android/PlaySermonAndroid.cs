using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PrekenWeb_App.Droid;
using PrekenWeb_App.Model.DependencyClasses;
using Xamarin.Forms;

[assembly: Dependency (typeof(PlaySermonAndroid))]

namespace PrekenWeb_App.Droid
{
    
    public class PlaySermonAndroid : IPlaySermon
    {
        private StreamingBackgroundService service;

        public void PlayOnlineSermon(string url)
        {
            this.service = new StreamingBackgroundService();
            service._filename = url;
            var intent = new Intent(StreamingBackgroundService.ActionPlay);
            service.StartService(intent);
        }

        public void PauseOnlineSermon(string url)
        {
            var intent = new Intent(StreamingBackgroundService.ActionPause);
            service.StartService(intent);
        }

        public void StopOnlineSermon(string url)
        {
            var intent = new Intent(StreamingBackgroundService.ActionStop);
            service.StartService(intent);
        }
    }

    [Service]
    [IntentFilter(new []{ActionPlay,ActionPause,ActionStop})]
    public class StreamingBackgroundService : Service
    {
        //actions
        public const string ActionPlay = "com.xamarin.action.PLAY";
        public const string ActionPause = "com.xamarin.action.PAUSE";
        public const string ActionStop = "com.xamarin.action.STOP";

        public string _filename { get; set; }

        private MediaPlayer player;

        public StreamingBackgroundService() { }
        

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            switch (intent.Action)
            {
                case ActionPlay: Play();
                    break;
                case ActionStop: Stop();
                    break;
                case ActionPause: Pause();
                    break;
            }
            return StartCommandResult.Sticky;
        }

        public override IBinder OnBind(Intent intent)
        {
            return new Binder();
        }

        public void OnAudioFocusChange(AudioFocus focusChange)
        {
            return;
        }

        private async void Play()
        {
            player = new MediaPlayer();
            player.Prepared += (sender, args) => player.Start();
            player.Completion += (sender, args) => Stop();
            player.Error += (sender, args) =>
            {
                Console.WriteLine("Error in playing: " + args.What);
                Stop();
            };

            await player.SetDataSourceAsync(ApplicationContext, Android.Net.Uri.Parse(_filename));
            player.PrepareAsync();
        }

        private void Stop()
        {
            player.Stop();
        }

        private void Pause()
        {
            
        }
    }

}