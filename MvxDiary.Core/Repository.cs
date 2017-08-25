using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxDiary.Core.Models;
using SQLite;

namespace MvxDiary.Core
{
    public class Repository
    {
        private readonly SQLiteAsyncConnection _connection;

        public string StatusMessage { get; set; }

        public Repository(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<DiaryItem>().Wait();
        }

        public async Task CreateDiaryItem(DiaryItem item)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(item.Title) || string.IsNullOrWhiteSpace(item.Description))
                {
                    throw new Exception("Diary title and description required.");
                }

                var queryResult = await _connection.InsertAsync(item).ConfigureAwait(continueOnCapturedContext: false);
                StatusMessage = $"{queryResult} item added [Title: {item.Title}]";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to create item. Error: {ex.Message}";
            }
        }

        public Task<List<DiaryItem>> GetAllDiaryItems()
        {
            return _connection.Table<DiaryItem>().ToListAsync();
        }
    }
}
