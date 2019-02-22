using dbmasteraapp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using dbmasteraapp.Custom;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(MyStatusBarEffect), "StatusBarEffect")]
namespace dbmasteraapp.Droid
{
    class MyStatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var backgroundColor = StatusBarEffect.GetBackgroundColor().ToAndroid();
            Window window = Globals.Window;
            window.SetStatusBarColor(backgroundColor);
        }

        protected override void OnDetached()
        {
        }
       
    }
}