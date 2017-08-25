using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace MvxDiary.Core.ViewModels
{
    public class MainScreenViewModel : MvxViewModel
    {
        public ICommand NavigateAddDiaryItem
        {
            get { return new MvxCommand(() => ShowViewModel<AddDiaryItemViewModel>());}
        }
        public ICommand NavigateAllDiaryItems
        {
            get { return new MvxCommand(() => ShowViewModel<AllDiaryItemsViewModel>()); }
        }
    }
}
