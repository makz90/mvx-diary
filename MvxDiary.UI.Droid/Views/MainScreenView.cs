using Android.App;
using MvvmCross.Droid.Views;

namespace MvxDiary.UI.Droid.Views
{
    [Activity(Label = "Mvx Diary", Theme = "@style/MyCustomTheme")]
    public class MainScreenView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_MainScreen);
        }
    }
}