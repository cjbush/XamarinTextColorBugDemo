using App1.Custom;
using App1.iOS.Custom;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryIos))]

namespace App1.iOS.Custom
{
    public sealed class CustomEntryIos : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.TextColor = new UIColor(CoreImage.CIColor.WhiteColor); //This blows up
            Control.TextColor = UIColor.White; //This works fine
        }

    }
}