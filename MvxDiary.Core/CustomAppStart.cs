using MvvmCross.Core.ViewModels;
using MvxDiary.Core.ViewModels;

namespace MvxDiary.Core
{
    class CustomAppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainScreenViewModel>();
        }
    }
}
