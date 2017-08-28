using Android.App;
using MvvmCross.Droid.Views;

namespace MvxDiary.UI.Droid.Views
{
    [Activity(Label = "Diary items", Theme = "@style/MyCustomTheme")]
    public class AllDiaryItemsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_AllDiaryItems);
        }
    }
}