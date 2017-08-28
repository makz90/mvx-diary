using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxDiary.UI.Droid.Views
{
    [Activity(Theme = "@style/MyCustomTheme", Label = "AddDiaryItemView", NoHistory = true)]
    public class AddDiaryItemView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_AddDiaryItem);
        }
    }
}