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

            catch(ArgumentException)
            {
                OutputHandling.Error("PATH NAMES CANNOT CONTAIN SPECIAL CHARACTERS OR EMPTY SPACES");
            }

            catch(DirectoryNotFoundException)
            {
                OutputHandling.Error("NO SUCH DIRECTORY!");
            }

            catch(FileNotFoundException)
            {
                OutputHandling.Error("FILE NOT FOUND!");
            }

            catch(UnauthorizedAccessException)
            {
                OutputHandling.Error("YOU ARE NOT ALLOWED TO ACCESS THIS PATH");
            }

            catch(Exception)
            {
                OutputHandling.Error("UNKNOWN EXCEPTION");
            }

            finally
            {
                fileContents.Clear();
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
