using System;
using SQLite;

namespace MvxDiary.Core.Models
{
    public class DiaryItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(100)]
        public string Title { get; set; }

        [NotNull, MaxLength(1000)]
        public string Description { get; set; }

        [NotNull]
        public DateTime Date { get; set; }

        public DiaryItem()
        {
            Title = String.Empty;
            Description = String.Empty;
            Date = new DateTime();
        }
        public bool IsValid()
        {
            return (!String.IsNullOrWhiteSpace(Title) && !String.IsNullOrWhiteSpace(Description));
        }
    }
}
