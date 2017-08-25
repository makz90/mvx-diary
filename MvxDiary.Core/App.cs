using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxDiary.Core.Services;

namespace MvxDiary.Core
{
    class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IDateProvider, DateProvider>();
            var dateProvider = Mvx.Resolve<IDateProvider>();

            var appStart = new CustomAppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);
        }
    }
}
