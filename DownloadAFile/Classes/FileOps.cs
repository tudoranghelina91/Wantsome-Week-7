using System;
using System.Text;
using System.IO;
using IODS.Handlers;

namespace DownloadAFile.Classes
{
    class FileOps
    {
        public static void Rename(ref string fileName, Uri uri)
        {
            StringBuilder fileNameSB = new StringBuilder();
            fileNameSB.Append(DateTime.Now.ToString("MMddyyyyhhmmss"));
            fileNameSB.Append(" - ");
            fileNameSB.Append(Path.GetFileName(uri.LocalPath));

            fileName = fileNameSB.ToString();
        }

        public static string SetName(Uri uri)
        {
            StringBuilder fileName = new StringBuilder();
            fileName.Append(Path.GetFileName(uri.LocalPath));
            return fileName.ToString();
        }

        public static void TryOverWrite(string fileName, Uri uri)
        {
            if (File.Exists(fileName))
            {
                OutputHandling.Question($"There is already an existing file called {fileName}. Do you want to overwrite it? Y / N");

                if (!InputHandling.QuestionOptions(false))
                    FileOps.Rename(ref fileName, uri);
            }
        }
    }
}
