using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxDiary.Core.Models;

namespace MvxDiary.Core.ViewModels
{
    public class AllDiaryItemsViewModel : MvxViewModel
    {
        public List<DiaryItem> AllDiaryItems { get; set; }

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        public void Init()
        {
            Task<List<DiaryItem>> result = Mvx.Resolve<Repository>().GetAllDiaryItems();
            result.Wait();
            AllDiaryItems = result.Result;
        }
    }
}
