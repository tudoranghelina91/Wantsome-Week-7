using IODS.Handlers;
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
