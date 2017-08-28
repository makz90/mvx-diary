using System;

namespace MvxDiary.UI.Droid
{
    internal class FileAccessHelper
    {
        public static string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, fileName);
        }
    }
}