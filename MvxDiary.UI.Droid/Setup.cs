using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using MvxDiary.Core;

namespace MvxDiary.UI.Droid
{
    class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var dbConnection = FileAccessHelper.GetLocalFilePath("diary.db3");
            Mvx.RegisterSingleton(new Repository(dbConnection));
            return new App();
        }
    }
}