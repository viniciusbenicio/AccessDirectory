using System.Diagnostics;

namespace AccessDirectory
{
    public class DirectoryPath
    {
        public const string PATH_TEMP = @"C:\temp";

        
        public void ExecuteCloneCommand()
        {
            string urlRepositorio = "https://github.com/viniciusbenicio/BoilerplateCleanArch";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "git";
            startInfo.Arguments = $"clone {urlRepositorio} {PATH_TEMP}";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;


            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

            }


        }

        public string[] listDirectory()
        {
            var archives = Array.Empty<string>();
            if (Directory.Exists(PATH_TEMP))
            {
                archives = Directory.GetFiles(PATH_TEMP);
                Console.WriteLine("Archives: ");

                foreach (string archive in archives)
                {
                    Console.WriteLine(archive);
                }
            }

            return archives;
        }

    }
}
