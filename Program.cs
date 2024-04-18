using System;
using System.Diagnostics;
using System.IO;

namespace tumple_updater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string directoryCache = args[0];
                string directoryMain = args[1];

                try
                {
                    if (Directory.Exists(directoryCache) && Directory.Exists(directoryMain))
                    {
                        string[] allFiles = Directory.GetFiles(directoryCache, "*.*", SearchOption.AllDirectories);

                        foreach (string filename in allFiles)
                        {
                            string destinationPath = Path.Combine(directoryMain, filename.Replace(directoryCache, "").TrimStart('\\'));
                            string directoryPath = Path.GetDirectoryName(destinationPath);

                            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                            if (File.Exists(destinationPath)) File.Delete(destinationPath);

                            File.Move(filename, destinationPath);
                        }

                        StartProccess(directoryCache, directoryMain);
                    }
                }
                catch (Exception e)
                {

                }
            }
        }
        static void StartProccess(string directoryCache, string directoryMain)
        {
            string[] allDirectories = Directory.GetDirectories(directoryCache, "*.*", SearchOption.AllDirectories);
            Array.Reverse(allDirectories);

            foreach (string dirname in allDirectories)
            {
                Directory.Delete(dirname, false);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(directoryMain, "tumple-launcher.exe"));
            startInfo.Verb = "runas";
            Process.Start(startInfo);
        }
    }
}