using dbmasteraapp.iOS;
using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using dbmasteraapp.Custom;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(MyStatusBarEffect), "StatusBarEffect")]
namespace dbmasteraapp.iOS
{
    public class MyStatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = StatusBarEffect.GetBackgroundColor().ToUIColor();
            }
        }

        protected override void OnDetached()
        {

        }
    }
}