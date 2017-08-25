using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxDiary.Core.Models;
using MvxDiary.Core.Services;

namespace MvxDiary.Core.ViewModels
{
    public class AddDiaryItemViewModel : MvxViewModel
    {
        private readonly IDateProvider _dateProvider;
        private DiaryItem _diaryItem;

        public string Title
        {
            get { return _diaryItem.Title; }
            set
            {
                _diaryItem.Title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public string Description
        {
            get { return _diaryItem.Description; }
            set
            {
                _diaryItem.Description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        public DateTime Date
        {
            get { return _diaryItem.Date; }
            set
            {
                _diaryItem.Date = value;
                RaisePropertyChanged(() => Date);
            }
        }

        public AddDiaryItemViewModel(IDateProvider dateProvider)
        {
            _dateProvider = dateProvider;
        }

        public ICommand NavBack
        {
            get { return new MvxCommand(() => Close(this)); }
        }
        public ICommand SaveDiaryItem
        {
            get {
                return new MvxCommand(() => {
                    if (_diaryItem.IsValid())
                    {
                        Mvx.Resolve<Repository>().CreateDiaryItem(_diaryItem).Wait();
                        Close(this);
                    }
                });
            }
        }

        public void Init(DiaryItem diaryItem = null)
        {
            _diaryItem = diaryItem == null ? new DiaryItem() : diaryItem;
            _diaryItem.Date = _dateProvider.Today();
        }
    }
}
