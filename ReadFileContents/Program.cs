using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IODS.Handlers;
using System.IO;
using ReadFileContents.Classes;

namespace ReadFileContents
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = InputHandling.ReadString("Path to file to read: ");
            FileProcessing.ReadFileContents(filePath);
        }
    }
}
