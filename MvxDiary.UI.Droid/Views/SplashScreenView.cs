using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxDiary.UI.Droid.Views
{
    [Activity(Label= "My Diary",Theme = "@style/MyCustomTheme.Splash", MainLauncher = true, Icon = "@drawable/icon", NoHistory = true)]
    public class SplashScreenView : MvxSplashScreenActivity
    {
        public SplashScreenView() : base(Resource.Layout.View_SplashScreen)
        {
            
        }
    }
}