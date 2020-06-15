using System;
using Android.Content;
using HolaMundo.CustomControls;
using HolaMundo.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.FastRenderers;

[assembly: ExportRenderer(typeof(Label), typeof(ShadowedLabelRenderer))]
namespace HolaMundo.Droid.CustomRenderers
{ 

    public class ShadowedLabelRenderer: Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer
    {
        public ShadowedLabelRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.SetShadowLayer(10, 5, 5, Android.Graphics.Color.DarkGray);
        }
    }
}
