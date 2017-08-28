﻿using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvxDiary.Core;

namespace MvxDiary.UI.iOS
{
    class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter) : base(applicationDelegate, presenter)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}