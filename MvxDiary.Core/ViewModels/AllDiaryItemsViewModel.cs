using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxDiary.Core.Models;

namespace MvxDiary.Core.ViewModels
{
    class AllDiaryItemsViewModel : MvxViewModel
    {
        public List<DiaryItem> AllDiaryItems { get; set; }

        public ICommand NavBack
        {
            get { return new MvxCommand(() => Close(this)); }
        }

        public void Init()
        {
            Task<List<DiaryItem>> queryResult = Mvx.Resolve<Repository>().GetAllDiaryItems();
            queryResult.Wait();
            AllDiaryItems = queryResult.Result;
        }
    }
}
