using System;
using IODS.Handlers;
using System.Net;
using System.IO;

namespace DownloadAFile.Classes
{
    class Downloader
    {
        public static void Download(string url)
        {
            WebClient webClient = new WebClient();
            try
            {
                Uri uri = new Uri(url);
                string fileName = FileOps.SetName(uri);
                Uri currentPath = new Uri(Directory.GetCurrentDirectory() + '/' + fileName);


                if (uri.AbsolutePath == currentPath.AbsolutePath)
                {
                    OutputHandling.Error("UNABLE TO DOWNLOAD A FILE TO THE SAME LOCATION THAT THE ORIGINAL FILE RESIDES IN");
                    return;
                }

                try
                {
                    FileOps.TryOverWrite(ref fileName, uri);
                    Download(uri, fileName, webClient);
                }

                catch (WebException)
                {
                    OutputHandling.Error($"UNABLE TO DOWNLOAD {fileName}, PLEASE MAKE SURE THAT THE FILE PATH IS CORRECT");
                }

                finally
                {
                    webClient.Dispose();
                }
            }

            catch (UriFormatException)
            {
                OutputHandling.Error("INVALID URL FORMAT SPECIFIED");
            }

            finally
            {
                webClient.Dispose();
            }
        }

        public static void Download(Uri uri, string fileName, WebClient webClient)
        {
            OutputHandling.Message($"Downloading {fileName}...", ConsoleColor.Cyan);
            webClient.DownloadFile(uri, fileName);
            OutputHandling.Message($"{fileName} has been successfully downloaded", ConsoleColor.Green);
        }
    }
}
