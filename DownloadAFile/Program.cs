using System;
using IODS.Handlers;
using DownloadAFile.Classes;

namespace DownloadAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = InputHandling.ReadString("Url to download from: ");
            Downloader.Download(url);
            Console.ReadKey();
        }
    }
}
