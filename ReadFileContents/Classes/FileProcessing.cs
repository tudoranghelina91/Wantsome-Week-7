using System;
using System.Text;
using IODS.Handlers;
using System.IO;

namespace ReadFileContents.Classes
{
    static class FileProcessing
    {
        public static void ReadFileContents(string filePath)
        {
            StringBuilder fileContents = new StringBuilder();
            fileContents.Append("*** BEGINNING OF FILE***\n\n");

            try
            {
                fileContents.Append(File.ReadAllText(filePath));
                fileContents.Append("\n\n*** END OF FILE***");
                PrintFileContents(fileContents.ToString());
            }

            catch(FileNotFoundException)
            {
                fileContents.Clear();
                OutputHandling.Error("FILE NOT FOUND!");
            }

            catch(DirectoryNotFoundException)
            {
                fileContents.Clear();
                OutputHandling.Error("NO SUCH DIRECTORY!");
            }

            catch(ArgumentException)
            {
                fileContents.Clear();
                OutputHandling.Error("PATH NAMES CANNOT CONTAIN SPECIAL CHARACTERS OR EMPTY SPACES");
            }

            catch(UnauthorizedAccessException)
            {
                fileContents.Clear();
                OutputHandling.Error("YOU ARE NOT ALLOWED TO ACCESS THIS PATH");
            }

            catch(Exception)
            {
                throw;
            }

            finally
            {
                ExitProgram();
            }
        }

        public static void PrintFileContents(string fileContents)
        {
            OutputHandling.Message(fileContents);
        }

        public static void ExitProgram()
        {
            OutputHandling.Question("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
