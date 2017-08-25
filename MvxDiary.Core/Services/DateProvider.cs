using System;

namespace MvxDiary.Core.Services
{
    class DateProvider : IDateProvider
    {
        public DateTime Today()
        {
            return DateTime.Now;
        }
    }
}
