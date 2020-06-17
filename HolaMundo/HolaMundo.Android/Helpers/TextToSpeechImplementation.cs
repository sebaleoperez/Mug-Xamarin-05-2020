using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Speech.Tts;
using HolaMundo.Droid.Helpers;
using HolaMundo.Helpers;
using Xamarin.Forms;

[assembly:Xamarin.Forms.Dependency(typeof(TextToSpeechImplementation))]
namespace HolaMundo.Droid.Helpers
{
    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            //throw new NotImplementedException();
        }

        public void Speak(string text)
        {
            var ctx = Forms.Context;
            // useful for many Android SDK features
            toSpeak = text;

            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            var p = new Dictionary<string, string>();
            speaker.Speak(toSpeak, QueueMode.Flush, p);
        }
    }
}
